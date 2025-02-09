using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPointGaussianMapper
/// </summary>
/// <remarks>
///    draw PointGaussians using imposters
///
///
/// A mapper that uses imposters to draw gaussian splats or other shapes if
/// custom shader code is set. Supports transparency and picking as well. It
/// draws all the points and does not require cell arrays. If cell arrays are
/// provided it will only draw the points used by the Verts cell array. The shape
/// of the imposter is a triangle.
/// </remarks>
public class vtkPointGaussianMapper : vtkPolyDataMapper
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPointGaussianMapper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPointGaussianMapper()
	{
		MRClassNameKey = "class vtkPointGaussianMapper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointGaussianMapper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPointGaussianMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointGaussianMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPointGaussianMapper New()
	{
		vtkPointGaussianMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointGaussianMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointGaussianMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPointGaussianMapper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPointGaussianMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointGaussianMapper_EmissiveOff_01(HandleRef pThis);

	/// <summary>
	/// Treat the points/splats as emissive light sources. The default is true.
	/// </summary>
	public virtual void EmissiveOff()
	{
		vtkPointGaussianMapper_EmissiveOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointGaussianMapper_EmissiveOn_02(HandleRef pThis);

	/// <summary>
	/// Treat the points/splats as emissive light sources. The default is true.
	/// </summary>
	public virtual void EmissiveOn()
	{
		vtkPointGaussianMapper_EmissiveOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointGaussianMapper_GetEmissive_03(HandleRef pThis);

	/// <summary>
	/// Treat the points/splats as emissive light sources. The default is true.
	/// </summary>
	public virtual int GetEmissive()
	{
		return vtkPointGaussianMapper_GetEmissive_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointGaussianMapper_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPointGaussianMapper_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointGaussianMapper_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPointGaussianMapper_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointGaussianMapper_GetOpacityArray_06(HandleRef pThis);

	/// <summary>
	/// Method to set the optional opacity array.  If specified this
	/// array will be used to generate the opacity values.
	/// </summary>
	public virtual string GetOpacityArray()
	{
		return Marshal.PtrToStringAnsi(vtkPointGaussianMapper_GetOpacityArray_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointGaussianMapper_GetOpacityArrayComponent_07(HandleRef pThis);

	/// <summary>
	/// Convenience method to set the component of the array to opacify with.
	/// </summary>
	public virtual int GetOpacityArrayComponent()
	{
		return vtkPointGaussianMapper_GetOpacityArrayComponent_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointGaussianMapper_GetOpacityTableSize_08(HandleRef pThis);

	/// <summary>
	/// The size of the table used in computing opacities, used when
	/// converting a vtkPiecewiseFunction to a table
	/// </summary>
	public virtual int GetOpacityTableSize()
	{
		return vtkPointGaussianMapper_GetOpacityTableSize_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointGaussianMapper_GetScalarOpacityFunction_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the optional opacity transfer function. This is only
	/// used when an OpacityArray is also specified.
	/// </summary>
	public virtual vtkPiecewiseFunction GetScalarOpacityFunction()
	{
		vtkPiecewiseFunction vtkPiecewiseFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointGaussianMapper_GetScalarOpacityFunction_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPiecewiseFunction2 = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPiecewiseFunction2.Register(null);
			}
		}
		return vtkPiecewiseFunction2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointGaussianMapper_GetScaleArray_10(HandleRef pThis);

	/// <summary>
	/// Convenience method to set the array to scale with.
	/// </summary>
	public virtual string GetScaleArray()
	{
		return Marshal.PtrToStringAnsi(vtkPointGaussianMapper_GetScaleArray_10(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointGaussianMapper_GetScaleArrayComponent_11(HandleRef pThis);

	/// <summary>
	/// Convenience method to set the component of the array to scale with.
	/// </summary>
	public virtual int GetScaleArrayComponent()
	{
		return vtkPointGaussianMapper_GetScaleArrayComponent_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointGaussianMapper_GetScaleFactor_12(HandleRef pThis);

	/// <summary>
	/// Set the default scale factor of the point gaussians.  This
	/// defaults to 1.0. All radius computations will be scaled by the factor
	/// including the ScaleArray. If a vtkPiecewideFunction is used the
	/// scaling happens prior to the function lookup.
	/// A scale factor of 0.0 indicates that the splats should be rendered
	/// as simple points.
	/// </summary>
	public virtual double GetScaleFactor()
	{
		return vtkPointGaussianMapper_GetScaleFactor_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointGaussianMapper_GetScaleFunction_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the optional scale transfer function. This is only
	/// used when a ScaleArray is also specified.
	/// </summary>
	public virtual vtkPiecewiseFunction GetScaleFunction()
	{
		vtkPiecewiseFunction vtkPiecewiseFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointGaussianMapper_GetScaleFunction_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPiecewiseFunction2 = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPiecewiseFunction2.Register(null);
			}
		}
		return vtkPiecewiseFunction2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointGaussianMapper_GetScaleTableSize_14(HandleRef pThis);

	/// <summary>
	/// The size of the table used in computing scale, used when
	/// converting a vtkPiecewiseFunction to a table
	/// </summary>
	public virtual int GetScaleTableSize()
	{
		return vtkPointGaussianMapper_GetScaleTableSize_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointGaussianMapper_GetSplatShaderCode_15(HandleRef pThis);

	/// <summary>
	/// Method to override the fragment shader code for the splat.  You can
	/// set this to draw other shapes. For the OPenGL2 backend some of
	/// the variables you can use and/or modify include,
	/// opacity - 0.0 to 1.0
	/// diffuseColor - vec3
	/// ambientColor - vec3
	/// offsetVCVSOutput - vec2 offset in view coordinates from the splat center
	/// </summary>
	public virtual string GetSplatShaderCode()
	{
		return Marshal.PtrToStringAnsi(vtkPointGaussianMapper_GetSplatShaderCode_15(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPointGaussianMapper_GetSupportsSelection_16(HandleRef pThis);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// Used by vtkHardwareSelector to determine if the prop supports hardware
	/// selection.
	/// </summary>
	public override bool GetSupportsSelection()
	{
		return (vtkPointGaussianMapper_GetSupportsSelection_16(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkPointGaussianMapper_GetTriangleScale_17(HandleRef pThis);

	/// <summary>
	/// When drawing triangles as opposed too point mode
	/// (triangles are for splats shaders that are bigger than a pixel)
	/// this controls how large the triangle will be. By default it
	/// is large enough to contain a cicle of radius 3.0*scale which works
	/// well for gaussian splats as after 3.0 standard deviations the
	/// opacity is near zero. For custom shader codes a different
	/// value can be used. Generally you should use the lowest value you can
	/// as it will result in fewer fragments. For example if your custom
	/// shader only draws a disc of radius 1.0*scale, then set this to 1.0
	/// to avoid sending many fragments to the shader that will just get
	/// discarded.
	/// </summary>
	public virtual float GetTriangleScale()
	{
		return vtkPointGaussianMapper_GetTriangleScale_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointGaussianMapper_IsA_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPointGaussianMapper_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointGaussianMapper_IsTypeOf_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPointGaussianMapper_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointGaussianMapper_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPointGaussianMapper NewInstance()
	{
		vtkPointGaussianMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointGaussianMapper_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointGaussianMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointGaussianMapper_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPointGaussianMapper SafeDownCast(vtkObjectBase o)
	{
		vtkPointGaussianMapper vtkPointGaussianMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointGaussianMapper_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPointGaussianMapper2 = (vtkPointGaussianMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPointGaussianMapper2.Register(null);
			}
		}
		return vtkPointGaussianMapper2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointGaussianMapper_SetEmissive_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Treat the points/splats as emissive light sources. The default is true.
	/// </summary>
	public virtual void SetEmissive(int _arg)
	{
		vtkPointGaussianMapper_SetEmissive_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointGaussianMapper_SetOpacityArray_24(HandleRef pThis, string _arg);

	/// <summary>
	/// Method to set the optional opacity array.  If specified this
	/// array will be used to generate the opacity values.
	/// </summary>
	public virtual void SetOpacityArray(string _arg)
	{
		vtkPointGaussianMapper_SetOpacityArray_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointGaussianMapper_SetOpacityArrayComponent_25(HandleRef pThis, int _arg);

	/// <summary>
	/// Convenience method to set the component of the array to opacify with.
	/// </summary>
	public virtual void SetOpacityArrayComponent(int _arg)
	{
		vtkPointGaussianMapper_SetOpacityArrayComponent_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointGaussianMapper_SetOpacityTableSize_26(HandleRef pThis, int _arg);

	/// <summary>
	/// The size of the table used in computing opacities, used when
	/// converting a vtkPiecewiseFunction to a table
	/// </summary>
	public virtual void SetOpacityTableSize(int _arg)
	{
		vtkPointGaussianMapper_SetOpacityTableSize_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointGaussianMapper_SetScalarOpacityFunction_27(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the optional opacity transfer function. This is only
	/// used when an OpacityArray is also specified.
	/// </summary>
	public void SetScalarOpacityFunction(vtkPiecewiseFunction arg0)
	{
		vtkPointGaussianMapper_SetScalarOpacityFunction_27(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointGaussianMapper_SetScaleArray_28(HandleRef pThis, string _arg);

	/// <summary>
	/// Convenience method to set the array to scale with.
	/// </summary>
	public virtual void SetScaleArray(string _arg)
	{
		vtkPointGaussianMapper_SetScaleArray_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointGaussianMapper_SetScaleArrayComponent_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Convenience method to set the component of the array to scale with.
	/// </summary>
	public virtual void SetScaleArrayComponent(int _arg)
	{
		vtkPointGaussianMapper_SetScaleArrayComponent_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointGaussianMapper_SetScaleFactor_30(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the default scale factor of the point gaussians.  This
	/// defaults to 1.0. All radius computations will be scaled by the factor
	/// including the ScaleArray. If a vtkPiecewideFunction is used the
	/// scaling happens prior to the function lookup.
	/// A scale factor of 0.0 indicates that the splats should be rendered
	/// as simple points.
	/// </summary>
	public virtual void SetScaleFactor(double _arg)
	{
		vtkPointGaussianMapper_SetScaleFactor_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointGaussianMapper_SetScaleFunction_31(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the optional scale transfer function. This is only
	/// used when a ScaleArray is also specified.
	/// </summary>
	public void SetScaleFunction(vtkPiecewiseFunction arg0)
	{
		vtkPointGaussianMapper_SetScaleFunction_31(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointGaussianMapper_SetScaleTableSize_32(HandleRef pThis, int _arg);

	/// <summary>
	/// The size of the table used in computing scale, used when
	/// converting a vtkPiecewiseFunction to a table
	/// </summary>
	public virtual void SetScaleTableSize(int _arg)
	{
		vtkPointGaussianMapper_SetScaleTableSize_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointGaussianMapper_SetSplatShaderCode_33(HandleRef pThis, string _arg);

	/// <summary>
	/// Method to override the fragment shader code for the splat.  You can
	/// set this to draw other shapes. For the OPenGL2 backend some of
	/// the variables you can use and/or modify include,
	/// opacity - 0.0 to 1.0
	/// diffuseColor - vec3
	/// ambientColor - vec3
	/// offsetVCVSOutput - vec2 offset in view coordinates from the splat center
	/// </summary>
	public virtual void SetSplatShaderCode(string _arg)
	{
		vtkPointGaussianMapper_SetSplatShaderCode_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointGaussianMapper_SetTriangleScale_34(HandleRef pThis, float _arg);

	/// <summary>
	/// When drawing triangles as opposed too point mode
	/// (triangles are for splats shaders that are bigger than a pixel)
	/// this controls how large the triangle will be. By default it
	/// is large enough to contain a cicle of radius 3.0*scale which works
	/// well for gaussian splats as after 3.0 standard deviations the
	/// opacity is near zero. For custom shader codes a different
	/// value can be used. Generally you should use the lowest value you can
	/// as it will result in fewer fragments. For example if your custom
	/// shader only draws a disc of radius 1.0*scale, then set this to 1.0
	/// to avoid sending many fragments to the shader that will just get
	/// discarded.
	/// </summary>
	public virtual void SetTriangleScale(float _arg)
	{
		vtkPointGaussianMapper_SetTriangleScale_34(GetCppThis(), _arg);
	}
}
