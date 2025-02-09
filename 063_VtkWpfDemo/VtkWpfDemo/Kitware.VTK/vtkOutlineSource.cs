using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOutlineSource
/// </summary>
/// <remarks>
///    create wireframe outline around bounding box
///
/// vtkOutlineSource creates a wireframe outline around a
/// user-specified bounding box.  The outline may be created aligned
/// with the {x,y,z} axis - in which case it is defined by the 6 bounds
/// {xmin,xmax,ymin,ymax,zmin,zmax} via SetBounds(). Alternatively, the
/// box may be arbitrarily aligned, in which case it should be set via
/// the SetCorners() member.
/// </remarks>
public class vtkOutlineSource : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOutlineSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOutlineSource()
	{
		MRClassNameKey = "class vtkOutlineSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOutlineSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOutlineSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOutlineSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation. type information, and printing.
	/// </summary>
	public new static vtkOutlineSource New()
	{
		vtkOutlineSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOutlineSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOutlineSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation. type information, and printing.
	/// </summary>
	public vtkOutlineSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOutlineSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkOutlineSource_GenerateFacesOff_01(HandleRef pThis);

	/// <summary>
	/// Generate solid faces for the box. This is off by default.
	/// </summary>
	public virtual void GenerateFacesOff()
	{
		vtkOutlineSource_GenerateFacesOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutlineSource_GenerateFacesOn_02(HandleRef pThis);

	/// <summary>
	/// Generate solid faces for the box. This is off by default.
	/// </summary>
	public virtual void GenerateFacesOn()
	{
		vtkOutlineSource_GenerateFacesOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOutlineSource_GetBounds_03(HandleRef pThis);

	/// <summary>
	/// Specify the bounds of the box to be used in Axis Aligned mode.
	/// </summary>
	public virtual double[] GetBounds()
	{
		IntPtr intPtr = vtkOutlineSource_GetBounds_03(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutlineSource_GetBounds_04(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify the bounds of the box to be used in Axis Aligned mode.
	/// </summary>
	public virtual void GetBounds(IntPtr data)
	{
		vtkOutlineSource_GetBounds_04(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOutlineSource_GetBoxType_05(HandleRef pThis);

	/// <summary>
	/// Set box type to AxisAligned (default) or Oriented.
	/// Use the method SetBounds() with AxisAligned mode, and SetCorners()
	/// with Oriented mode.
	/// </summary>
	public virtual int GetBoxType()
	{
		return vtkOutlineSource_GetBoxType_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOutlineSource_GetCorners_06(HandleRef pThis);

	/// <summary>
	/// Specify the corners of the outline when in Oriented mode, the
	/// values are supplied as 8*3 double values The correct corner
	/// ordering is using {x,y,z} convention for the unit cube as follows:
	/// {0,0,0},{1,0,0},{0,1,0},{1,1,0},{0,0,1},{1,0,1},{0,1,1},{1,1,1}.
	/// </summary>
	public virtual double[] GetCorners()
	{
		IntPtr intPtr = vtkOutlineSource_GetCorners_06(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutlineSource_GetCorners_07(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify the corners of the outline when in Oriented mode, the
	/// values are supplied as 8*3 double values The correct corner
	/// ordering is using {x,y,z} convention for the unit cube as follows:
	/// {0,0,0},{1,0,0},{0,1,0},{1,1,0},{0,0,1},{1,0,1},{0,1,1},{1,1,1}.
	/// </summary>
	public virtual void GetCorners(IntPtr data)
	{
		vtkOutlineSource_GetCorners_07(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOutlineSource_GetGenerateFaces_08(HandleRef pThis);

	/// <summary>
	/// Generate solid faces for the box. This is off by default.
	/// </summary>
	public virtual int GetGenerateFaces()
	{
		return vtkOutlineSource_GetGenerateFaces_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOutlineSource_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation. type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOutlineSource_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOutlineSource_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	/// Standard methods for instantiation. type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOutlineSource_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOutlineSource_GetOutputPointsPrecision_11(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkOutlineSource_GetOutputPointsPrecision_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOutlineSource_IsA_12(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation. type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOutlineSource_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOutlineSource_IsTypeOf_13(string type);

	/// <summary>
	/// Standard methods for instantiation. type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOutlineSource_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOutlineSource_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation. type information, and printing.
	/// </summary>
	public new vtkOutlineSource NewInstance()
	{
		vtkOutlineSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOutlineSource_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOutlineSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOutlineSource_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation. type information, and printing.
	/// </summary>
	public new static vtkOutlineSource SafeDownCast(vtkObjectBase o)
	{
		vtkOutlineSource vtkOutlineSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOutlineSource_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOutlineSource2 = (vtkOutlineSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOutlineSource2.Register(null);
			}
		}
		return vtkOutlineSource2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutlineSource_SetBounds_17(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

	/// <summary>
	/// Specify the bounds of the box to be used in Axis Aligned mode.
	/// </summary>
	public virtual void SetBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
	{
		vtkOutlineSource_SetBounds_17(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutlineSource_SetBounds_18(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the bounds of the box to be used in Axis Aligned mode.
	/// </summary>
	public virtual void SetBounds(IntPtr _arg)
	{
		vtkOutlineSource_SetBounds_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutlineSource_SetBoxType_19(HandleRef pThis, int _arg);

	/// <summary>
	/// Set box type to AxisAligned (default) or Oriented.
	/// Use the method SetBounds() with AxisAligned mode, and SetCorners()
	/// with Oriented mode.
	/// </summary>
	public virtual void SetBoxType(int _arg)
	{
		vtkOutlineSource_SetBoxType_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutlineSource_SetBoxTypeToAxisAligned_20(HandleRef pThis);

	/// <summary>
	/// Set box type to AxisAligned (default) or Oriented.
	/// Use the method SetBounds() with AxisAligned mode, and SetCorners()
	/// with Oriented mode.
	/// </summary>
	public void SetBoxTypeToAxisAligned()
	{
		vtkOutlineSource_SetBoxTypeToAxisAligned_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutlineSource_SetBoxTypeToOriented_21(HandleRef pThis);

	/// <summary>
	/// Set box type to AxisAligned (default) or Oriented.
	/// Use the method SetBounds() with AxisAligned mode, and SetCorners()
	/// with Oriented mode.
	/// </summary>
	public void SetBoxTypeToOriented()
	{
		vtkOutlineSource_SetBoxTypeToOriented_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutlineSource_SetCorners_22(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify the corners of the outline when in Oriented mode, the
	/// values are supplied as 8*3 double values The correct corner
	/// ordering is using {x,y,z} convention for the unit cube as follows:
	/// {0,0,0},{1,0,0},{0,1,0},{1,1,0},{0,0,1},{1,0,1},{0,1,1},{1,1,1}.
	/// </summary>
	public virtual void SetCorners(IntPtr data)
	{
		vtkOutlineSource_SetCorners_22(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutlineSource_SetGenerateFaces_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Generate solid faces for the box. This is off by default.
	/// </summary>
	public virtual void SetGenerateFaces(int _arg)
	{
		vtkOutlineSource_SetGenerateFaces_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOutlineSource_SetOutputPointsPrecision_24(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkOutlineSource_SetOutputPointsPrecision_24(GetCppThis(), _arg);
	}
}
