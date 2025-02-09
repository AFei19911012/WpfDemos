using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkThresholdTextureCoords
/// </summary>
/// <remarks>
///    compute 1D, 2D, or 3D texture coordinates based on scalar threshold
///
/// vtkThresholdTextureCoords is a filter that generates texture coordinates for
/// any input dataset type given a threshold criterion. The criterion can take
/// three forms: 1) greater than a particular value (ThresholdByUpper());
/// 2) less than a particular value (ThresholdByLower(); or 3) between two
/// values (ThresholdBetween(). If the threshold criterion is satisfied,
/// the "in" texture coordinate will be set (this can be specified by the
/// user). If the threshold criterion is not satisfied the "out" is set.
///
/// @warning
/// There is a texture map - texThres.vtk - that can be used in conjunction
/// with this filter. This map defines a "transparent" region for texture
/// coordinates 0&lt;=r&lt;0.5, and an opaque full intensity map for texture
/// coordinates 0.5&lt;r&lt;=1.0. There is a small transition region for r=0.5.
///
/// </remarks>
/// <seealso>
///
/// vtkThreshold vtkThresholdPoints vtkTextureMapToPlane vtkTextureMapToSphere
/// vtkTextureMapToCylinder
/// </seealso>
public class vtkThresholdTextureCoords : vtkDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkThresholdTextureCoords";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkThresholdTextureCoords()
	{
		MRClassNameKey = "class vtkThresholdTextureCoords";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkThresholdTextureCoords"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkThresholdTextureCoords(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkThresholdTextureCoords_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkThresholdTextureCoords New()
	{
		vtkThresholdTextureCoords result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkThresholdTextureCoords_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkThresholdTextureCoords)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkThresholdTextureCoords()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkThresholdTextureCoords_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkThresholdTextureCoords_GetInTextureCoord_01(HandleRef pThis);

	/// <summary>
	/// Set the texture coordinate value for point satisfying threshold criterion.
	/// </summary>
	public virtual double[] GetInTextureCoord()
	{
		IntPtr intPtr = vtkThresholdTextureCoords_GetInTextureCoord_01(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThresholdTextureCoords_GetInTextureCoord_02(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the texture coordinate value for point satisfying threshold criterion.
	/// </summary>
	public virtual void GetInTextureCoord(IntPtr data)
	{
		vtkThresholdTextureCoords_GetInTextureCoord_02(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkThresholdTextureCoords_GetLowerThreshold_03(HandleRef pThis);

	/// <summary>
	/// Return the upper and lower thresholds.
	/// </summary>
	public virtual double GetLowerThreshold()
	{
		return vtkThresholdTextureCoords_GetLowerThreshold_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkThresholdTextureCoords_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkThresholdTextureCoords_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkThresholdTextureCoords_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkThresholdTextureCoords_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkThresholdTextureCoords_GetOutTextureCoord_06(HandleRef pThis);

	/// <summary>
	/// Set the texture coordinate value for point NOT satisfying threshold
	/// criterion.
	/// </summary>
	public virtual double[] GetOutTextureCoord()
	{
		IntPtr intPtr = vtkThresholdTextureCoords_GetOutTextureCoord_06(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThresholdTextureCoords_GetOutTextureCoord_07(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the texture coordinate value for point NOT satisfying threshold
	/// criterion.
	/// </summary>
	public virtual void GetOutTextureCoord(IntPtr data)
	{
		vtkThresholdTextureCoords_GetOutTextureCoord_07(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThresholdTextureCoords_GetTextureDimension_08(HandleRef pThis);

	/// <summary>
	/// Set the desired dimension of the texture map.
	/// </summary>
	public virtual int GetTextureDimension()
	{
		return vtkThresholdTextureCoords_GetTextureDimension_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThresholdTextureCoords_GetTextureDimensionMaxValue_09(HandleRef pThis);

	/// <summary>
	/// Set the desired dimension of the texture map.
	/// </summary>
	public virtual int GetTextureDimensionMaxValue()
	{
		return vtkThresholdTextureCoords_GetTextureDimensionMaxValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThresholdTextureCoords_GetTextureDimensionMinValue_10(HandleRef pThis);

	/// <summary>
	/// Set the desired dimension of the texture map.
	/// </summary>
	public virtual int GetTextureDimensionMinValue()
	{
		return vtkThresholdTextureCoords_GetTextureDimensionMinValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkThresholdTextureCoords_GetUpperThreshold_11(HandleRef pThis);

	/// <summary>
	/// Return the upper and lower thresholds.
	/// </summary>
	public virtual double GetUpperThreshold()
	{
		return vtkThresholdTextureCoords_GetUpperThreshold_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThresholdTextureCoords_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkThresholdTextureCoords_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThresholdTextureCoords_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkThresholdTextureCoords_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkThresholdTextureCoords_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkThresholdTextureCoords NewInstance()
	{
		vtkThresholdTextureCoords result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkThresholdTextureCoords_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkThresholdTextureCoords)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkThresholdTextureCoords_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkThresholdTextureCoords SafeDownCast(vtkObjectBase o)
	{
		vtkThresholdTextureCoords vtkThresholdTextureCoords2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkThresholdTextureCoords_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkThresholdTextureCoords2 = (vtkThresholdTextureCoords)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkThresholdTextureCoords2.Register(null);
			}
		}
		return vtkThresholdTextureCoords2;
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThresholdTextureCoords_SetInTextureCoord_17(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the texture coordinate value for point satisfying threshold criterion.
	/// </summary>
	public virtual void SetInTextureCoord(double _arg1, double _arg2, double _arg3)
	{
		vtkThresholdTextureCoords_SetInTextureCoord_17(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThresholdTextureCoords_SetInTextureCoord_18(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the texture coordinate value for point satisfying threshold criterion.
	/// </summary>
	public virtual void SetInTextureCoord(IntPtr _arg)
	{
		vtkThresholdTextureCoords_SetInTextureCoord_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThresholdTextureCoords_SetOutTextureCoord_19(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the texture coordinate value for point NOT satisfying threshold
	/// criterion.
	/// </summary>
	public virtual void SetOutTextureCoord(double _arg1, double _arg2, double _arg3)
	{
		vtkThresholdTextureCoords_SetOutTextureCoord_19(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThresholdTextureCoords_SetOutTextureCoord_20(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the texture coordinate value for point NOT satisfying threshold
	/// criterion.
	/// </summary>
	public virtual void SetOutTextureCoord(IntPtr _arg)
	{
		vtkThresholdTextureCoords_SetOutTextureCoord_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThresholdTextureCoords_SetTextureDimension_21(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the desired dimension of the texture map.
	/// </summary>
	public virtual void SetTextureDimension(int _arg)
	{
		vtkThresholdTextureCoords_SetTextureDimension_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThresholdTextureCoords_ThresholdBetween_22(HandleRef pThis, double lower, double upper);

	/// <summary>
	/// Criterion is cells whose scalars are between lower and upper thresholds.
	/// </summary>
	public void ThresholdBetween(double lower, double upper)
	{
		vtkThresholdTextureCoords_ThresholdBetween_22(GetCppThis(), lower, upper);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThresholdTextureCoords_ThresholdByLower_23(HandleRef pThis, double lower);

	/// <summary>
	/// Criterion is cells whose scalars are less than lower threshold.
	/// </summary>
	public void ThresholdByLower(double lower)
	{
		vtkThresholdTextureCoords_ThresholdByLower_23(GetCppThis(), lower);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThresholdTextureCoords_ThresholdByUpper_24(HandleRef pThis, double upper);

	/// <summary>
	/// Criterion is cells whose scalars are less than upper threshold.
	/// </summary>
	public void ThresholdByUpper(double upper)
	{
		vtkThresholdTextureCoords_ThresholdByUpper_24(GetCppThis(), upper);
	}
}
