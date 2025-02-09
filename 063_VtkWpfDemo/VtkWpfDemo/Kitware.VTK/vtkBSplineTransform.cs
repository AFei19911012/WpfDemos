using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBSplineTransform
/// </summary>
/// <remarks>
///    a cubic b-spline deformation transformation
///
/// vtkBSplineTransform computes a cubic b-spline transformation from a
/// grid of b-spline coefficients.
/// @warning
/// The inverse grid transform is calculated using an iterative method,
/// and is several times more expensive than the forward transform.
/// </remarks>
/// <seealso>
///
/// vtkGeneralTransform vtkTransformToGrid vtkImageBSplineCoefficients
/// @par Thanks:
/// This class was written by David Gobbi at the Seaman Family MR Research
/// Centre, Foothills Medical Centre, Calgary, Alberta.
/// DG Gobbi and YP Starreveld,
/// "Uniform B-Splines for the VTK Imaging Pipeline,"
/// VTK Journal, 2011,
/// http://hdl.handle.net/10380/3252
/// </seealso>
public class vtkBSplineTransform : vtkWarpTransform
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBSplineTransform";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBSplineTransform()
	{
		MRClassNameKey = "class vtkBSplineTransform";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBSplineTransform"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBSplineTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBSplineTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBSplineTransform New()
	{
		vtkBSplineTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBSplineTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBSplineTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkBSplineTransform()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBSplineTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkBSplineTransform_GetBorderMode_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the border mode, to alter behavior at the edge of the grid.
	/// The Edge mode allows the displacement to converge to the edge
	/// coefficient past the boundary, which is similar to the behavior of
	/// the vtkGridTransform. The Zero mode allows the displacement to
	/// smoothly converge to zero two node-spacings past the boundary,
	/// which is useful when you want to create a localized transform.
	/// The ZeroAtBorder mode sacrifices smoothness to further localize
	/// the transform to just one node-spacing past the boundary.
	/// </summary>
	public virtual int GetBorderMode()
	{
		return vtkBSplineTransform_GetBorderMode_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBSplineTransform_GetBorderModeAsString_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the border mode, to alter behavior at the edge of the grid.
	/// The Edge mode allows the displacement to converge to the edge
	/// coefficient past the boundary, which is similar to the behavior of
	/// the vtkGridTransform. The Zero mode allows the displacement to
	/// smoothly converge to zero two node-spacings past the boundary,
	/// which is useful when you want to create a localized transform.
	/// The ZeroAtBorder mode sacrifices smoothness to further localize
	/// the transform to just one node-spacing past the boundary.
	/// </summary>
	public string GetBorderModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkBSplineTransform_GetBorderModeAsString_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBSplineTransform_GetBorderModeMaxValue_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the border mode, to alter behavior at the edge of the grid.
	/// The Edge mode allows the displacement to converge to the edge
	/// coefficient past the boundary, which is similar to the behavior of
	/// the vtkGridTransform. The Zero mode allows the displacement to
	/// smoothly converge to zero two node-spacings past the boundary,
	/// which is useful when you want to create a localized transform.
	/// The ZeroAtBorder mode sacrifices smoothness to further localize
	/// the transform to just one node-spacing past the boundary.
	/// </summary>
	public virtual int GetBorderModeMaxValue()
	{
		return vtkBSplineTransform_GetBorderModeMaxValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBSplineTransform_GetBorderModeMinValue_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the border mode, to alter behavior at the edge of the grid.
	/// The Edge mode allows the displacement to converge to the edge
	/// coefficient past the boundary, which is similar to the behavior of
	/// the vtkGridTransform. The Zero mode allows the displacement to
	/// smoothly converge to zero two node-spacings past the boundary,
	/// which is useful when you want to create a localized transform.
	/// The ZeroAtBorder mode sacrifices smoothness to further localize
	/// the transform to just one node-spacing past the boundary.
	/// </summary>
	public virtual int GetBorderModeMinValue()
	{
		return vtkBSplineTransform_GetBorderModeMinValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBSplineTransform_GetCoefficientData_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the coefficient grid for the b-spline transform.
	/// The vtkBSplineTransform class will never modify the data.
	/// Note that SetCoefficientData() does not setup a pipeline
	/// connection whereas SetCoefficientConnection does.
	/// </summary>
	public virtual vtkImageData GetCoefficientData()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBSplineTransform_GetCoefficientData_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkBSplineTransform_GetDisplacementScale_06(HandleRef pThis);

	/// <summary>
	/// Set/Get a scale to apply to the transformation.
	/// </summary>
	public virtual double GetDisplacementScale()
	{
		return vtkBSplineTransform_GetDisplacementScale_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkBSplineTransform_GetMTime_07(HandleRef pThis);

	/// <summary>
	/// Get the MTime.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkBSplineTransform_GetMTime_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBSplineTransform_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBSplineTransform_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBSplineTransform_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBSplineTransform_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBSplineTransform_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBSplineTransform_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBSplineTransform_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBSplineTransform_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBSplineTransform_MakeTransform_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Make another transform of the same type.
	/// </summary>
	public override vtkAbstractTransform MakeTransform()
	{
		vtkAbstractTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBSplineTransform_MakeTransform_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBSplineTransform_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkBSplineTransform NewInstance()
	{
		vtkBSplineTransform result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBSplineTransform_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBSplineTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBSplineTransform_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBSplineTransform SafeDownCast(vtkObjectBase o)
	{
		vtkBSplineTransform vtkBSplineTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBSplineTransform_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBSplineTransform2 = (vtkBSplineTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBSplineTransform2.Register(null);
			}
		}
		return vtkBSplineTransform2;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBSplineTransform_SetBorderMode_16(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the border mode, to alter behavior at the edge of the grid.
	/// The Edge mode allows the displacement to converge to the edge
	/// coefficient past the boundary, which is similar to the behavior of
	/// the vtkGridTransform. The Zero mode allows the displacement to
	/// smoothly converge to zero two node-spacings past the boundary,
	/// which is useful when you want to create a localized transform.
	/// The ZeroAtBorder mode sacrifices smoothness to further localize
	/// the transform to just one node-spacing past the boundary.
	/// </summary>
	public virtual void SetBorderMode(int _arg)
	{
		vtkBSplineTransform_SetBorderMode_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBSplineTransform_SetBorderModeToEdge_17(HandleRef pThis);

	/// <summary>
	/// Set/Get the border mode, to alter behavior at the edge of the grid.
	/// The Edge mode allows the displacement to converge to the edge
	/// coefficient past the boundary, which is similar to the behavior of
	/// the vtkGridTransform. The Zero mode allows the displacement to
	/// smoothly converge to zero two node-spacings past the boundary,
	/// which is useful when you want to create a localized transform.
	/// The ZeroAtBorder mode sacrifices smoothness to further localize
	/// the transform to just one node-spacing past the boundary.
	/// </summary>
	public void SetBorderModeToEdge()
	{
		vtkBSplineTransform_SetBorderModeToEdge_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBSplineTransform_SetBorderModeToZero_18(HandleRef pThis);

	/// <summary>
	/// Set/Get the border mode, to alter behavior at the edge of the grid.
	/// The Edge mode allows the displacement to converge to the edge
	/// coefficient past the boundary, which is similar to the behavior of
	/// the vtkGridTransform. The Zero mode allows the displacement to
	/// smoothly converge to zero two node-spacings past the boundary,
	/// which is useful when you want to create a localized transform.
	/// The ZeroAtBorder mode sacrifices smoothness to further localize
	/// the transform to just one node-spacing past the boundary.
	/// </summary>
	public void SetBorderModeToZero()
	{
		vtkBSplineTransform_SetBorderModeToZero_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBSplineTransform_SetBorderModeToZeroAtBorder_19(HandleRef pThis);

	/// <summary>
	/// Set/Get the border mode, to alter behavior at the edge of the grid.
	/// The Edge mode allows the displacement to converge to the edge
	/// coefficient past the boundary, which is similar to the behavior of
	/// the vtkGridTransform. The Zero mode allows the displacement to
	/// smoothly converge to zero two node-spacings past the boundary,
	/// which is useful when you want to create a localized transform.
	/// The ZeroAtBorder mode sacrifices smoothness to further localize
	/// the transform to just one node-spacing past the boundary.
	/// </summary>
	public void SetBorderModeToZeroAtBorder()
	{
		vtkBSplineTransform_SetBorderModeToZeroAtBorder_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBSplineTransform_SetCoefficientConnection_20(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the coefficient grid for the b-spline transform.
	/// The vtkBSplineTransform class will never modify the data.
	/// Note that SetCoefficientData() does not setup a pipeline
	/// connection whereas SetCoefficientConnection does.
	/// </summary>
	public virtual void SetCoefficientConnection(vtkAlgorithmOutput arg0)
	{
		vtkBSplineTransform_SetCoefficientConnection_20(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBSplineTransform_SetCoefficientData_21(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the coefficient grid for the b-spline transform.
	/// The vtkBSplineTransform class will never modify the data.
	/// Note that SetCoefficientData() does not setup a pipeline
	/// connection whereas SetCoefficientConnection does.
	/// </summary>
	public virtual void SetCoefficientData(vtkImageData arg0)
	{
		vtkBSplineTransform_SetCoefficientData_21(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBSplineTransform_SetDisplacementScale_22(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get a scale to apply to the transformation.
	/// </summary>
	public virtual void SetDisplacementScale(double _arg)
	{
		vtkBSplineTransform_SetDisplacementScale_22(GetCppThis(), _arg);
	}
}
