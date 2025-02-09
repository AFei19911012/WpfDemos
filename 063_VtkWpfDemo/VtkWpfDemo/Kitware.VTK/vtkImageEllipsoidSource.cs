using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageEllipsoidSource
/// </summary>
/// <remarks>
///    Create a binary image of an ellipsoid.
///
/// vtkImageEllipsoidSource creates a binary image of a ellipsoid.  It was created
/// as an example of a simple source, and to test the mask filter.
/// It is also used internally in vtkImageDilateErode3D.
/// </remarks>
public class vtkImageEllipsoidSource : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageEllipsoidSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageEllipsoidSource()
	{
		MRClassNameKey = "class vtkImageEllipsoidSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageEllipsoidSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageEllipsoidSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageEllipsoidSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageEllipsoidSource New()
	{
		vtkImageEllipsoidSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageEllipsoidSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageEllipsoidSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageEllipsoidSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageEllipsoidSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageEllipsoidSource_GetCenter_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the center of the ellipsoid.
	/// </summary>
	public virtual double[] GetCenter()
	{
		IntPtr intPtr = vtkImageEllipsoidSource_GetCenter_01(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageEllipsoidSource_GetCenter_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the center of the ellipsoid.
	/// </summary>
	public virtual void GetCenter(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageEllipsoidSource_GetCenter_02(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageEllipsoidSource_GetCenter_03(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the center of the ellipsoid.
	/// </summary>
	public virtual void GetCenter(IntPtr _arg)
	{
		vtkImageEllipsoidSource_GetCenter_03(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageEllipsoidSource_GetInValue_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the inside pixel values.
	/// </summary>
	public virtual double GetInValue()
	{
		return vtkImageEllipsoidSource_GetInValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageEllipsoidSource_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageEllipsoidSource_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageEllipsoidSource_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageEllipsoidSource_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageEllipsoidSource_GetOutValue_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the outside pixel values.
	/// </summary>
	public virtual double GetOutValue()
	{
		return vtkImageEllipsoidSource_GetOutValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageEllipsoidSource_GetOutputScalarType_08(HandleRef pThis);

	/// <summary>
	/// Set what type of scalar data this source should generate.
	/// </summary>
	public virtual int GetOutputScalarType()
	{
		return vtkImageEllipsoidSource_GetOutputScalarType_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageEllipsoidSource_GetRadius_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the radius of the ellipsoid.
	/// </summary>
	public virtual double[] GetRadius()
	{
		IntPtr intPtr = vtkImageEllipsoidSource_GetRadius_09(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageEllipsoidSource_GetRadius_10(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the radius of the ellipsoid.
	/// </summary>
	public virtual void GetRadius(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageEllipsoidSource_GetRadius_10(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageEllipsoidSource_GetRadius_11(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the radius of the ellipsoid.
	/// </summary>
	public virtual void GetRadius(IntPtr _arg)
	{
		vtkImageEllipsoidSource_GetRadius_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageEllipsoidSource_GetWholeExtent_12(HandleRef pThis, IntPtr extent);

	/// <summary>
	/// Set/Get the extent of the whole output image.
	/// </summary>
	public void GetWholeExtent(IntPtr extent)
	{
		vtkImageEllipsoidSource_GetWholeExtent_12(GetCppThis(), extent);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageEllipsoidSource_GetWholeExtent_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the extent of the whole output image.
	/// </summary>
	public int[] GetWholeExtent()
	{
		IntPtr intPtr = vtkImageEllipsoidSource_GetWholeExtent_13(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageEllipsoidSource_IsA_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageEllipsoidSource_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageEllipsoidSource_IsTypeOf_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageEllipsoidSource_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageEllipsoidSource_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageEllipsoidSource NewInstance()
	{
		vtkImageEllipsoidSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageEllipsoidSource_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageEllipsoidSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageEllipsoidSource_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageEllipsoidSource SafeDownCast(vtkObjectBase o)
	{
		vtkImageEllipsoidSource vtkImageEllipsoidSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageEllipsoidSource_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageEllipsoidSource2 = (vtkImageEllipsoidSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageEllipsoidSource2.Register(null);
			}
		}
		return vtkImageEllipsoidSource2;
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageEllipsoidSource_SetCenter_19(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the center of the ellipsoid.
	/// </summary>
	public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
	{
		vtkImageEllipsoidSource_SetCenter_19(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageEllipsoidSource_SetCenter_20(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the center of the ellipsoid.
	/// </summary>
	public virtual void SetCenter(IntPtr _arg)
	{
		vtkImageEllipsoidSource_SetCenter_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageEllipsoidSource_SetInValue_21(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the inside pixel values.
	/// </summary>
	public virtual void SetInValue(double _arg)
	{
		vtkImageEllipsoidSource_SetInValue_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageEllipsoidSource_SetOutValue_22(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the outside pixel values.
	/// </summary>
	public virtual void SetOutValue(double _arg)
	{
		vtkImageEllipsoidSource_SetOutValue_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageEllipsoidSource_SetOutputScalarType_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Set what type of scalar data this source should generate.
	/// </summary>
	public virtual void SetOutputScalarType(int _arg)
	{
		vtkImageEllipsoidSource_SetOutputScalarType_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageEllipsoidSource_SetOutputScalarTypeToChar_24(HandleRef pThis);

	/// <summary>
	/// Set what type of scalar data this source should generate.
	/// </summary>
	public void SetOutputScalarTypeToChar()
	{
		vtkImageEllipsoidSource_SetOutputScalarTypeToChar_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageEllipsoidSource_SetOutputScalarTypeToDouble_25(HandleRef pThis);

	/// <summary>
	/// Set what type of scalar data this source should generate.
	/// </summary>
	public void SetOutputScalarTypeToDouble()
	{
		vtkImageEllipsoidSource_SetOutputScalarTypeToDouble_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageEllipsoidSource_SetOutputScalarTypeToFloat_26(HandleRef pThis);

	/// <summary>
	/// Set what type of scalar data this source should generate.
	/// </summary>
	public void SetOutputScalarTypeToFloat()
	{
		vtkImageEllipsoidSource_SetOutputScalarTypeToFloat_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageEllipsoidSource_SetOutputScalarTypeToInt_27(HandleRef pThis);

	/// <summary>
	/// Set what type of scalar data this source should generate.
	/// </summary>
	public void SetOutputScalarTypeToInt()
	{
		vtkImageEllipsoidSource_SetOutputScalarTypeToInt_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageEllipsoidSource_SetOutputScalarTypeToLong_28(HandleRef pThis);

	/// <summary>
	/// Set what type of scalar data this source should generate.
	/// </summary>
	public void SetOutputScalarTypeToLong()
	{
		vtkImageEllipsoidSource_SetOutputScalarTypeToLong_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageEllipsoidSource_SetOutputScalarTypeToShort_29(HandleRef pThis);

	/// <summary>
	/// Set what type of scalar data this source should generate.
	/// </summary>
	public void SetOutputScalarTypeToShort()
	{
		vtkImageEllipsoidSource_SetOutputScalarTypeToShort_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageEllipsoidSource_SetOutputScalarTypeToUnsignedChar_30(HandleRef pThis);

	/// <summary>
	/// Set what type of scalar data this source should generate.
	/// </summary>
	public void SetOutputScalarTypeToUnsignedChar()
	{
		vtkImageEllipsoidSource_SetOutputScalarTypeToUnsignedChar_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageEllipsoidSource_SetOutputScalarTypeToUnsignedInt_31(HandleRef pThis);

	/// <summary>
	/// Set what type of scalar data this source should generate.
	/// </summary>
	public void SetOutputScalarTypeToUnsignedInt()
	{
		vtkImageEllipsoidSource_SetOutputScalarTypeToUnsignedInt_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageEllipsoidSource_SetOutputScalarTypeToUnsignedLong_32(HandleRef pThis);

	/// <summary>
	/// Set what type of scalar data this source should generate.
	/// </summary>
	public void SetOutputScalarTypeToUnsignedLong()
	{
		vtkImageEllipsoidSource_SetOutputScalarTypeToUnsignedLong_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageEllipsoidSource_SetOutputScalarTypeToUnsignedShort_33(HandleRef pThis);

	/// <summary>
	/// Set what type of scalar data this source should generate.
	/// </summary>
	public void SetOutputScalarTypeToUnsignedShort()
	{
		vtkImageEllipsoidSource_SetOutputScalarTypeToUnsignedShort_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageEllipsoidSource_SetRadius_34(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the radius of the ellipsoid.
	/// </summary>
	public virtual void SetRadius(double _arg1, double _arg2, double _arg3)
	{
		vtkImageEllipsoidSource_SetRadius_34(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageEllipsoidSource_SetRadius_35(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the radius of the ellipsoid.
	/// </summary>
	public virtual void SetRadius(IntPtr _arg)
	{
		vtkImageEllipsoidSource_SetRadius_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageEllipsoidSource_SetWholeExtent_36(HandleRef pThis, IntPtr extent);

	/// <summary>
	/// Set/Get the extent of the whole output image.
	/// </summary>
	public void SetWholeExtent(IntPtr extent)
	{
		vtkImageEllipsoidSource_SetWholeExtent_36(GetCppThis(), extent);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageEllipsoidSource_SetWholeExtent_37(HandleRef pThis, int minX, int maxX, int minY, int maxY, int minZ, int maxZ);

	/// <summary>
	/// Set/Get the extent of the whole output image.
	/// </summary>
	public void SetWholeExtent(int minX, int maxX, int minY, int maxY, int minZ, int maxZ)
	{
		vtkImageEllipsoidSource_SetWholeExtent_37(GetCppThis(), minX, maxX, minY, maxY, minZ, maxZ);
	}
}
