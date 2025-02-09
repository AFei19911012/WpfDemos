using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSampleFunction
/// </summary>
/// <remarks>
///    sample an implicit function over a structured point set
///
/// vtkSampleFunction is a source object that evaluates an implicit function
/// and normals at each point in a vtkStructuredPoints. The user can specify
/// the sample dimensions and location in space to perform the sampling. To
/// create closed surfaces (in conjunction with the vtkContourFilter), capping
/// can be turned on to set a particular value on the boundaries of the sample
/// space.
///
/// </remarks>
/// <seealso>
///
/// vtkImplicitModeller
/// </seealso>
public class vtkSampleFunction : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSampleFunction";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSampleFunction()
	{
		MRClassNameKey = "class vtkSampleFunction";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSampleFunction"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSampleFunction(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSampleFunction_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct with ModelBounds=(-1,1,-1,1,-1,1), SampleDimensions=(50,50,50),
	/// Capping turned off, and normal generation on.
	/// </summary>
	public new static vtkSampleFunction New()
	{
		vtkSampleFunction result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSampleFunction_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSampleFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct with ModelBounds=(-1,1,-1,1,-1,1), SampleDimensions=(50,50,50),
	/// Capping turned off, and normal generation on.
	/// </summary>
	public vtkSampleFunction()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSampleFunction_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSampleFunction_CappingOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off capping. If capping is on, then the outer boundaries of the
	/// structured point set are set to cap value. This can be used to ensure
	/// surfaces are closed.
	/// </summary>
	public virtual void CappingOff()
	{
		vtkSampleFunction_CappingOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSampleFunction_CappingOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off capping. If capping is on, then the outer boundaries of the
	/// structured point set are set to cap value. This can be used to ensure
	/// surfaces are closed.
	/// </summary>
	public virtual void CappingOn()
	{
		vtkSampleFunction_CappingOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSampleFunction_ComputeNormalsOff_03(HandleRef pThis);

	/// <summary>
	/// Turn on/off the computation of normals (normals are float values).
	/// </summary>
	public virtual void ComputeNormalsOff()
	{
		vtkSampleFunction_ComputeNormalsOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSampleFunction_ComputeNormalsOn_04(HandleRef pThis);

	/// <summary>
	/// Turn on/off the computation of normals (normals are float values).
	/// </summary>
	public virtual void ComputeNormalsOn()
	{
		vtkSampleFunction_ComputeNormalsOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSampleFunction_GetCapValue_05(HandleRef pThis);

	/// <summary>
	/// Set the cap value.
	/// </summary>
	public virtual double GetCapValue()
	{
		return vtkSampleFunction_GetCapValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSampleFunction_GetCapping_06(HandleRef pThis);

	/// <summary>
	/// Turn on/off capping. If capping is on, then the outer boundaries of the
	/// structured point set are set to cap value. This can be used to ensure
	/// surfaces are closed.
	/// </summary>
	public virtual int GetCapping()
	{
		return vtkSampleFunction_GetCapping_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSampleFunction_GetComputeNormals_07(HandleRef pThis);

	/// <summary>
	/// Turn on/off the computation of normals (normals are float values).
	/// </summary>
	public virtual int GetComputeNormals()
	{
		return vtkSampleFunction_GetComputeNormals_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSampleFunction_GetImplicitFunction_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the implicit function to use to generate data.
	/// </summary>
	public virtual vtkImplicitFunction GetImplicitFunction()
	{
		vtkImplicitFunction vtkImplicitFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSampleFunction_GetImplicitFunction_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkSampleFunction_GetMTime_09(HandleRef pThis);

	/// <summary>
	/// Return the MTime also considering the implicit function.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkSampleFunction_GetMTime_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSampleFunction_GetModelBounds_10(HandleRef pThis);

	/// <summary>
	/// Specify the region in space over which the sampling occurs. The
	/// bounds is specified as (xMin,xMax, yMin,yMax, zMin,zMax).
	/// </summary>
	public virtual double[] GetModelBounds()
	{
		IntPtr intPtr = vtkSampleFunction_GetModelBounds_10(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSampleFunction_GetModelBounds_11(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify the region in space over which the sampling occurs. The
	/// bounds is specified as (xMin,xMax, yMin,yMax, zMin,zMax).
	/// </summary>
	public virtual void GetModelBounds(IntPtr data)
	{
		vtkSampleFunction_GetModelBounds_11(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSampleFunction_GetNormalArrayName_12(HandleRef pThis);

	/// <summary>
	/// Set/get the normal array name for this data set. Initial value is
	/// "normals".
	/// </summary>
	public virtual string GetNormalArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkSampleFunction_GetNormalArrayName_12(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSampleFunction_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSampleFunction_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSampleFunction_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSampleFunction_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSampleFunction_GetOutputScalarType_15(HandleRef pThis);

	/// <summary>
	/// Set what type of scalar data this source should generate.
	/// </summary>
	public virtual int GetOutputScalarType()
	{
		return vtkSampleFunction_GetOutputScalarType_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSampleFunction_GetSampleDimensions_16(HandleRef pThis);

	/// <summary>
	/// Specify the dimensions of the data on which to sample.
	/// </summary>
	public virtual int[] GetSampleDimensions()
	{
		IntPtr intPtr = vtkSampleFunction_GetSampleDimensions_16(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSampleFunction_GetSampleDimensions_17(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify the dimensions of the data on which to sample.
	/// </summary>
	public virtual void GetSampleDimensions(IntPtr data)
	{
		vtkSampleFunction_GetSampleDimensions_17(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSampleFunction_GetScalarArrayName_18(HandleRef pThis);

	/// <summary>
	/// Set/get the scalar array name for this data set. Initial value is
	/// "scalars".
	/// </summary>
	public virtual string GetScalarArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkSampleFunction_GetScalarArrayName_18(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSampleFunction_IsA_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSampleFunction_IsA_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSampleFunction_IsTypeOf_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSampleFunction_IsTypeOf_20(type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSampleFunction_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSampleFunction NewInstance()
	{
		vtkSampleFunction result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSampleFunction_NewInstance_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSampleFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSampleFunction_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSampleFunction SafeDownCast(vtkObjectBase o)
	{
		vtkSampleFunction vtkSampleFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSampleFunction_SafeDownCast_23(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSampleFunction2 = (vtkSampleFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSampleFunction2.Register(null);
			}
		}
		return vtkSampleFunction2;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSampleFunction_SetCapValue_24(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the cap value.
	/// </summary>
	public virtual void SetCapValue(double _arg)
	{
		vtkSampleFunction_SetCapValue_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSampleFunction_SetCapping_25(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off capping. If capping is on, then the outer boundaries of the
	/// structured point set are set to cap value. This can be used to ensure
	/// surfaces are closed.
	/// </summary>
	public virtual void SetCapping(int _arg)
	{
		vtkSampleFunction_SetCapping_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSampleFunction_SetComputeNormals_26(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the computation of normals (normals are float values).
	/// </summary>
	public virtual void SetComputeNormals(int _arg)
	{
		vtkSampleFunction_SetComputeNormals_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSampleFunction_SetImplicitFunction_27(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the implicit function to use to generate data.
	/// </summary>
	public virtual void SetImplicitFunction(vtkImplicitFunction arg0)
	{
		vtkSampleFunction_SetImplicitFunction_27(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSampleFunction_SetModelBounds_28(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Specify the region in space over which the sampling occurs. The
	/// bounds is specified as (xMin,xMax, yMin,yMax, zMin,zMax).
	/// </summary>
	public void SetModelBounds(IntPtr bounds)
	{
		vtkSampleFunction_SetModelBounds_28(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSampleFunction_SetModelBounds_29(HandleRef pThis, double xMin, double xMax, double yMin, double yMax, double zMin, double zMax);

	/// <summary>
	/// Specify the region in space over which the sampling occurs. The
	/// bounds is specified as (xMin,xMax, yMin,yMax, zMin,zMax).
	/// </summary>
	public void SetModelBounds(double xMin, double xMax, double yMin, double yMax, double zMin, double zMax)
	{
		vtkSampleFunction_SetModelBounds_29(GetCppThis(), xMin, xMax, yMin, yMax, zMin, zMax);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSampleFunction_SetNormalArrayName_30(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/get the normal array name for this data set. Initial value is
	/// "normals".
	/// </summary>
	public virtual void SetNormalArrayName(string _arg)
	{
		vtkSampleFunction_SetNormalArrayName_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSampleFunction_SetOutputScalarType_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Set what type of scalar data this source should generate.
	/// </summary>
	public virtual void SetOutputScalarType(int _arg)
	{
		vtkSampleFunction_SetOutputScalarType_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSampleFunction_SetOutputScalarTypeToChar_32(HandleRef pThis);

	/// <summary>
	/// Set what type of scalar data this source should generate.
	/// </summary>
	public void SetOutputScalarTypeToChar()
	{
		vtkSampleFunction_SetOutputScalarTypeToChar_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSampleFunction_SetOutputScalarTypeToDouble_33(HandleRef pThis);

	/// <summary>
	/// Set what type of scalar data this source should generate.
	/// </summary>
	public void SetOutputScalarTypeToDouble()
	{
		vtkSampleFunction_SetOutputScalarTypeToDouble_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSampleFunction_SetOutputScalarTypeToFloat_34(HandleRef pThis);

	/// <summary>
	/// Set what type of scalar data this source should generate.
	/// </summary>
	public void SetOutputScalarTypeToFloat()
	{
		vtkSampleFunction_SetOutputScalarTypeToFloat_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSampleFunction_SetOutputScalarTypeToInt_35(HandleRef pThis);

	/// <summary>
	/// Set what type of scalar data this source should generate.
	/// </summary>
	public void SetOutputScalarTypeToInt()
	{
		vtkSampleFunction_SetOutputScalarTypeToInt_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSampleFunction_SetOutputScalarTypeToLong_36(HandleRef pThis);

	/// <summary>
	/// Set what type of scalar data this source should generate.
	/// </summary>
	public void SetOutputScalarTypeToLong()
	{
		vtkSampleFunction_SetOutputScalarTypeToLong_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSampleFunction_SetOutputScalarTypeToShort_37(HandleRef pThis);

	/// <summary>
	/// Set what type of scalar data this source should generate.
	/// </summary>
	public void SetOutputScalarTypeToShort()
	{
		vtkSampleFunction_SetOutputScalarTypeToShort_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSampleFunction_SetOutputScalarTypeToUnsignedChar_38(HandleRef pThis);

	/// <summary>
	/// Set what type of scalar data this source should generate.
	/// </summary>
	public void SetOutputScalarTypeToUnsignedChar()
	{
		vtkSampleFunction_SetOutputScalarTypeToUnsignedChar_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSampleFunction_SetOutputScalarTypeToUnsignedInt_39(HandleRef pThis);

	/// <summary>
	/// Set what type of scalar data this source should generate.
	/// </summary>
	public void SetOutputScalarTypeToUnsignedInt()
	{
		vtkSampleFunction_SetOutputScalarTypeToUnsignedInt_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSampleFunction_SetOutputScalarTypeToUnsignedLong_40(HandleRef pThis);

	/// <summary>
	/// Set what type of scalar data this source should generate.
	/// </summary>
	public void SetOutputScalarTypeToUnsignedLong()
	{
		vtkSampleFunction_SetOutputScalarTypeToUnsignedLong_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSampleFunction_SetOutputScalarTypeToUnsignedShort_41(HandleRef pThis);

	/// <summary>
	/// Set what type of scalar data this source should generate.
	/// </summary>
	public void SetOutputScalarTypeToUnsignedShort()
	{
		vtkSampleFunction_SetOutputScalarTypeToUnsignedShort_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSampleFunction_SetSampleDimensions_42(HandleRef pThis, int i, int j, int k);

	/// <summary>
	/// Specify the dimensions of the data on which to sample.
	/// </summary>
	public void SetSampleDimensions(int i, int j, int k)
	{
		vtkSampleFunction_SetSampleDimensions_42(GetCppThis(), i, j, k);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSampleFunction_SetSampleDimensions_43(HandleRef pThis, IntPtr dim);

	/// <summary>
	/// Specify the dimensions of the data on which to sample.
	/// </summary>
	public void SetSampleDimensions(IntPtr dim)
	{
		vtkSampleFunction_SetSampleDimensions_43(GetCppThis(), dim);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSampleFunction_SetScalarArrayName_44(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/get the scalar array name for this data set. Initial value is
	/// "scalars".
	/// </summary>
	public virtual void SetScalarArrayName(string _arg)
	{
		vtkSampleFunction_SetScalarArrayName_44(GetCppThis(), _arg);
	}
}
