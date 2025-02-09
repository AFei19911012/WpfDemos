using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkParametricFunctionSource
/// </summary>
/// <remarks>
///    tessellate parametric functions
///
/// This class tessellates parametric functions. The user must specify how
/// many points in the parametric coordinate directions are required (i.e.,
/// the resolution), and the mode to use to generate scalars.
///
/// @par Thanks:
/// Andrew Maclean andrew.amaclean@gmail.com for creating and contributing
/// the class.
///
/// </remarks>
/// <seealso>
///
/// vtkParametricFunction
///
///
/// Implementation of parametrics for 1D lines:
/// vtkParametricSpline
///
///
/// Subclasses of vtkParametricFunction implementing non-orentable surfaces:
/// vtkParametricBoy vtkParametricCrossCap vtkParametricFigure8Klein
/// vtkParametricKlein vtkParametricMobius vtkParametricRoman
///
///
/// Subclasses of vtkParametricFunction implementing orientable surfaces:
/// vtkParametricConicSpiral vtkParametricDini vtkParametricEllipsoid
/// vtkParametricEnneper vtkParametricRandomHills vtkParametricSuperEllipsoid
/// vtkParametricSuperToroid vtkParametricTorus
///
/// </seealso>
public class vtkParametricFunctionSource : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Enumerate the supported scalar generation modes.&lt;br&gt;
	/// SCALAR_NONE - Scalars are not generated (default).&lt;br&gt;
	/// SCALAR_U - The scalar is set to the u-value.&lt;br&gt;
	/// SCALAR_V - The scalar is set to the v-value.&lt;br&gt;
	/// SCALAR_U0 - The scalar is set to 1 if
	/// u = (u_max - u_min)/2 = u_avg, 0 otherwise.&lt;br&gt;
	/// SCALAR_V0 - The scalar is set to 1 if
	/// v = (v_max - v_min)/2 = v_avg, 0 otherwise.&lt;br&gt;
	/// SCALAR_U0V0 - The scalar is
	/// set to 1 if u == u_avg, 2 if v == v_avg,
	/// 3 if u = u_avg &amp;&amp; v = v_avg, 0 otherwise.&lt;br&gt;
	/// SCALAR_MODULUS - The scalar is set to (sqrt(u*u+v*v)),
	/// this is measured relative to (u_avg,v_avg).&lt;br&gt;
	/// SCALAR_PHASE - The scalar is set to (atan2(v,u))
	/// (in degrees, 0 to 360),
	/// this is measured relative to (u_avg,v_avg).&lt;br&gt;
	/// SCALAR_QUADRANT - The scalar is set to 1, 2, 3 or 4.
	/// depending upon the quadrant of the point (u,v).&lt;br&gt;
	/// SCALAR_X - The scalar is set to the x-value.&lt;br&gt;
	/// SCALAR_Y - The scalar is set to the y-value.&lt;br&gt;
	/// SCALAR_Z - The scalar is set to the z-value.&lt;br&gt;
	/// SCALAR_DISTANCE - The scalar is set to (sqrt(x*x+y*y+z*z)).
	/// I.e. distance from the origin.&lt;br&gt;
	/// SCALAR_USER_DEFINED - The scalar is set to the value
	/// returned from EvaluateScalar().&lt;br&gt;
	/// </summary>
	public enum SCALAR_MODE
	{
		/// <summary>enum member</summary>
		SCALAR_DISTANCE = 12,
		/// <summary>enum member</summary>
		SCALAR_FUNCTION_DEFINED = 13,
		/// <summary>enum member</summary>
		SCALAR_MODULUS = 6,
		/// <summary>enum member</summary>
		SCALAR_NONE = 0,
		/// <summary>enum member</summary>
		SCALAR_PHASE = 7,
		/// <summary>enum member</summary>
		SCALAR_QUADRANT = 8,
		/// <summary>enum member</summary>
		SCALAR_U = 1,
		/// <summary>enum member</summary>
		SCALAR_U0 = 3,
		/// <summary>enum member</summary>
		SCALAR_U0V0 = 5,
		/// <summary>enum member</summary>
		SCALAR_V = 2,
		/// <summary>enum member</summary>
		SCALAR_V0 = 4,
		/// <summary>enum member</summary>
		SCALAR_X = 9,
		/// <summary>enum member</summary>
		SCALAR_Y = 10,
		/// <summary>enum member</summary>
		SCALAR_Z = 11
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkParametricFunctionSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkParametricFunctionSource()
	{
		MRClassNameKey = "class vtkParametricFunctionSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkParametricFunctionSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkParametricFunctionSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParametricFunctionSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create a new instance with (50,50,50) points in the (u-v-w) directions.
	/// </summary>
	public new static vtkParametricFunctionSource New()
	{
		vtkParametricFunctionSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParametricFunctionSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkParametricFunctionSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Create a new instance with (50,50,50) points in the (u-v-w) directions.
	/// </summary>
	public vtkParametricFunctionSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkParametricFunctionSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkParametricFunctionSource_GenerateNormalsOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the generation of normals. This is on by
	/// default.
	/// Note that this is only applicable to parametric surfaces
	/// whose parametric dimension is 2.
	/// </summary>
	public virtual void GenerateNormalsOff()
	{
		vtkParametricFunctionSource_GenerateNormalsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunctionSource_GenerateNormalsOn_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the generation of normals. This is on by
	/// default.
	/// Note that this is only applicable to parametric surfaces
	/// whose parametric dimension is 2.
	/// </summary>
	public virtual void GenerateNormalsOn()
	{
		vtkParametricFunctionSource_GenerateNormalsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunctionSource_GenerateTextureCoordinatesOff_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the generation of texture coordinates. This is off by
	/// default.
	/// Note that this is only applicable to parametric surfaces
	/// whose parametric dimension is 2.
	/// Note that texturing may fail in some cases.
	/// </summary>
	public virtual void GenerateTextureCoordinatesOff()
	{
		vtkParametricFunctionSource_GenerateTextureCoordinatesOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunctionSource_GenerateTextureCoordinatesOn_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the generation of texture coordinates. This is off by
	/// default.
	/// Note that this is only applicable to parametric surfaces
	/// whose parametric dimension is 2.
	/// Note that texturing may fail in some cases.
	/// </summary>
	public virtual void GenerateTextureCoordinatesOn()
	{
		vtkParametricFunctionSource_GenerateTextureCoordinatesOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunctionSource_GetGenerateNormals_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the generation of normals. This is on by
	/// default.
	/// Note that this is only applicable to parametric surfaces
	/// whose parametric dimension is 2.
	/// </summary>
	public virtual int GetGenerateNormals()
	{
		return vtkParametricFunctionSource_GetGenerateNormals_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunctionSource_GetGenerateNormalsMaxValue_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the generation of normals. This is on by
	/// default.
	/// Note that this is only applicable to parametric surfaces
	/// whose parametric dimension is 2.
	/// </summary>
	public virtual int GetGenerateNormalsMaxValue()
	{
		return vtkParametricFunctionSource_GetGenerateNormalsMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunctionSource_GetGenerateNormalsMinValue_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the generation of normals. This is on by
	/// default.
	/// Note that this is only applicable to parametric surfaces
	/// whose parametric dimension is 2.
	/// </summary>
	public virtual int GetGenerateNormalsMinValue()
	{
		return vtkParametricFunctionSource_GetGenerateNormalsMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunctionSource_GetGenerateTextureCoordinates_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the generation of texture coordinates. This is off by
	/// default.
	/// Note that this is only applicable to parametric surfaces
	/// whose parametric dimension is 2.
	/// Note that texturing may fail in some cases.
	/// </summary>
	public virtual int GetGenerateTextureCoordinates()
	{
		return vtkParametricFunctionSource_GetGenerateTextureCoordinates_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunctionSource_GetGenerateTextureCoordinatesMaxValue_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the generation of texture coordinates. This is off by
	/// default.
	/// Note that this is only applicable to parametric surfaces
	/// whose parametric dimension is 2.
	/// Note that texturing may fail in some cases.
	/// </summary>
	public virtual int GetGenerateTextureCoordinatesMaxValue()
	{
		return vtkParametricFunctionSource_GetGenerateTextureCoordinatesMaxValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunctionSource_GetGenerateTextureCoordinatesMinValue_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the generation of texture coordinates. This is off by
	/// default.
	/// Note that this is only applicable to parametric surfaces
	/// whose parametric dimension is 2.
	/// Note that texturing may fail in some cases.
	/// </summary>
	public virtual int GetGenerateTextureCoordinatesMinValue()
	{
		return vtkParametricFunctionSource_GetGenerateTextureCoordinatesMinValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkParametricFunctionSource_GetMTime_11(HandleRef pThis);

	/// <summary>
	/// Return the MTime also considering the parametric function.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkParametricFunctionSource_GetMTime_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParametricFunctionSource_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkParametricFunctionSource_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParametricFunctionSource_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkParametricFunctionSource_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunctionSource_GetOutputPointsPrecision_14(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// See the documentation for the vtkAlgorithm::Precision enum for an
	/// explanation of the available precision settings.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkParametricFunctionSource_GetOutputPointsPrecision_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParametricFunctionSource_GetParametricFunction_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the parametric function to use to generate the tessellation.
	/// </summary>
	public virtual vtkParametricFunction GetParametricFunction()
	{
		vtkParametricFunction vtkParametricFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParametricFunctionSource_GetParametricFunction_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkParametricFunction2 = (vtkParametricFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkParametricFunction2.Register(null);
			}
		}
		return vtkParametricFunction2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunctionSource_GetScalarMode_16(HandleRef pThis);

	/// <summary>
	/// Get/Set the mode used for the scalar data.
	/// See SCALAR_MODE for a description of the types of scalars generated.
	/// </summary>
	public virtual int GetScalarMode()
	{
		return vtkParametricFunctionSource_GetScalarMode_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunctionSource_GetScalarModeMaxValue_17(HandleRef pThis);

	/// <summary>
	/// Get/Set the mode used for the scalar data.
	/// See SCALAR_MODE for a description of the types of scalars generated.
	/// </summary>
	public virtual int GetScalarModeMaxValue()
	{
		return vtkParametricFunctionSource_GetScalarModeMaxValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunctionSource_GetScalarModeMinValue_18(HandleRef pThis);

	/// <summary>
	/// Get/Set the mode used for the scalar data.
	/// See SCALAR_MODE for a description of the types of scalars generated.
	/// </summary>
	public virtual int GetScalarModeMinValue()
	{
		return vtkParametricFunctionSource_GetScalarModeMinValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunctionSource_GetUResolution_19(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of subdivisions / tessellations in the u parametric
	/// direction. Note that the number of tessellant points in the u
	/// direction is the UResolution + 1.
	/// </summary>
	public virtual int GetUResolution()
	{
		return vtkParametricFunctionSource_GetUResolution_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunctionSource_GetUResolutionMaxValue_20(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of subdivisions / tessellations in the u parametric
	/// direction. Note that the number of tessellant points in the u
	/// direction is the UResolution + 1.
	/// </summary>
	public virtual int GetUResolutionMaxValue()
	{
		return vtkParametricFunctionSource_GetUResolutionMaxValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunctionSource_GetUResolutionMinValue_21(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of subdivisions / tessellations in the u parametric
	/// direction. Note that the number of tessellant points in the u
	/// direction is the UResolution + 1.
	/// </summary>
	public virtual int GetUResolutionMinValue()
	{
		return vtkParametricFunctionSource_GetUResolutionMinValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunctionSource_GetVResolution_22(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of subdivisions / tessellations in the v parametric
	/// direction. Note that the number of tessellant points in the v
	/// direction is the VResolution + 1.
	/// </summary>
	public virtual int GetVResolution()
	{
		return vtkParametricFunctionSource_GetVResolution_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunctionSource_GetVResolutionMaxValue_23(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of subdivisions / tessellations in the v parametric
	/// direction. Note that the number of tessellant points in the v
	/// direction is the VResolution + 1.
	/// </summary>
	public virtual int GetVResolutionMaxValue()
	{
		return vtkParametricFunctionSource_GetVResolutionMaxValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunctionSource_GetVResolutionMinValue_24(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of subdivisions / tessellations in the v parametric
	/// direction. Note that the number of tessellant points in the v
	/// direction is the VResolution + 1.
	/// </summary>
	public virtual int GetVResolutionMinValue()
	{
		return vtkParametricFunctionSource_GetVResolutionMinValue_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunctionSource_GetWResolution_25(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of subdivisions / tessellations in the w parametric
	/// direction. Note that the number of tessellant points in the w
	/// direction is the WResolution + 1.
	/// </summary>
	public virtual int GetWResolution()
	{
		return vtkParametricFunctionSource_GetWResolution_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunctionSource_GetWResolutionMaxValue_26(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of subdivisions / tessellations in the w parametric
	/// direction. Note that the number of tessellant points in the w
	/// direction is the WResolution + 1.
	/// </summary>
	public virtual int GetWResolutionMaxValue()
	{
		return vtkParametricFunctionSource_GetWResolutionMaxValue_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunctionSource_GetWResolutionMinValue_27(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of subdivisions / tessellations in the w parametric
	/// direction. Note that the number of tessellant points in the w
	/// direction is the WResolution + 1.
	/// </summary>
	public virtual int GetWResolutionMinValue()
	{
		return vtkParametricFunctionSource_GetWResolutionMinValue_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunctionSource_IsA_28(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkParametricFunctionSource_IsA_28(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParametricFunctionSource_IsTypeOf_29(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkParametricFunctionSource_IsTypeOf_29(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParametricFunctionSource_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkParametricFunctionSource NewInstance()
	{
		vtkParametricFunctionSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParametricFunctionSource_NewInstance_31(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkParametricFunctionSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParametricFunctionSource_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkParametricFunctionSource SafeDownCast(vtkObjectBase o)
	{
		vtkParametricFunctionSource vtkParametricFunctionSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParametricFunctionSource_SafeDownCast_32(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkParametricFunctionSource2 = (vtkParametricFunctionSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkParametricFunctionSource2.Register(null);
			}
		}
		return vtkParametricFunctionSource2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunctionSource_SetGenerateNormals_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the generation of normals. This is on by
	/// default.
	/// Note that this is only applicable to parametric surfaces
	/// whose parametric dimension is 2.
	/// </summary>
	public virtual void SetGenerateNormals(int _arg)
	{
		vtkParametricFunctionSource_SetGenerateNormals_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunctionSource_SetGenerateTextureCoordinates_34(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the generation of texture coordinates. This is off by
	/// default.
	/// Note that this is only applicable to parametric surfaces
	/// whose parametric dimension is 2.
	/// Note that texturing may fail in some cases.
	/// </summary>
	public virtual void SetGenerateTextureCoordinates(int _arg)
	{
		vtkParametricFunctionSource_SetGenerateTextureCoordinates_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunctionSource_SetOutputPointsPrecision_35(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// See the documentation for the vtkAlgorithm::Precision enum for an
	/// explanation of the available precision settings.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkParametricFunctionSource_SetOutputPointsPrecision_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunctionSource_SetParametricFunction_36(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the parametric function to use to generate the tessellation.
	/// </summary>
	public virtual void SetParametricFunction(vtkParametricFunction arg0)
	{
		vtkParametricFunctionSource_SetParametricFunction_36(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunctionSource_SetScalarMode_37(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the mode used for the scalar data.
	/// See SCALAR_MODE for a description of the types of scalars generated.
	/// </summary>
	public virtual void SetScalarMode(int _arg)
	{
		vtkParametricFunctionSource_SetScalarMode_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunctionSource_SetScalarModeToDistance_38(HandleRef pThis);

	/// <summary>
	/// Get/Set the mode used for the scalar data.
	/// See SCALAR_MODE for a description of the types of scalars generated.
	/// </summary>
	public void SetScalarModeToDistance()
	{
		vtkParametricFunctionSource_SetScalarModeToDistance_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunctionSource_SetScalarModeToFunctionDefined_39(HandleRef pThis);

	/// <summary>
	/// Get/Set the mode used for the scalar data.
	/// See SCALAR_MODE for a description of the types of scalars generated.
	/// </summary>
	public void SetScalarModeToFunctionDefined()
	{
		vtkParametricFunctionSource_SetScalarModeToFunctionDefined_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunctionSource_SetScalarModeToModulus_40(HandleRef pThis);

	/// <summary>
	/// Get/Set the mode used for the scalar data.
	/// See SCALAR_MODE for a description of the types of scalars generated.
	/// </summary>
	public void SetScalarModeToModulus()
	{
		vtkParametricFunctionSource_SetScalarModeToModulus_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunctionSource_SetScalarModeToNone_41(HandleRef pThis);

	/// <summary>
	/// Get/Set the mode used for the scalar data.
	/// See SCALAR_MODE for a description of the types of scalars generated.
	/// </summary>
	public void SetScalarModeToNone()
	{
		vtkParametricFunctionSource_SetScalarModeToNone_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunctionSource_SetScalarModeToPhase_42(HandleRef pThis);

	/// <summary>
	/// Get/Set the mode used for the scalar data.
	/// See SCALAR_MODE for a description of the types of scalars generated.
	/// </summary>
	public void SetScalarModeToPhase()
	{
		vtkParametricFunctionSource_SetScalarModeToPhase_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunctionSource_SetScalarModeToQuadrant_43(HandleRef pThis);

	/// <summary>
	/// Get/Set the mode used for the scalar data.
	/// See SCALAR_MODE for a description of the types of scalars generated.
	/// </summary>
	public void SetScalarModeToQuadrant()
	{
		vtkParametricFunctionSource_SetScalarModeToQuadrant_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunctionSource_SetScalarModeToU_44(HandleRef pThis);

	/// <summary>
	/// Get/Set the mode used for the scalar data.
	/// See SCALAR_MODE for a description of the types of scalars generated.
	/// </summary>
	public void SetScalarModeToU()
	{
		vtkParametricFunctionSource_SetScalarModeToU_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunctionSource_SetScalarModeToU0_45(HandleRef pThis);

	/// <summary>
	/// Get/Set the mode used for the scalar data.
	/// See SCALAR_MODE for a description of the types of scalars generated.
	/// </summary>
	public void SetScalarModeToU0()
	{
		vtkParametricFunctionSource_SetScalarModeToU0_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunctionSource_SetScalarModeToU0V0_46(HandleRef pThis);

	/// <summary>
	/// Get/Set the mode used for the scalar data.
	/// See SCALAR_MODE for a description of the types of scalars generated.
	/// </summary>
	public void SetScalarModeToU0V0()
	{
		vtkParametricFunctionSource_SetScalarModeToU0V0_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunctionSource_SetScalarModeToV_47(HandleRef pThis);

	/// <summary>
	/// Get/Set the mode used for the scalar data.
	/// See SCALAR_MODE for a description of the types of scalars generated.
	/// </summary>
	public void SetScalarModeToV()
	{
		vtkParametricFunctionSource_SetScalarModeToV_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunctionSource_SetScalarModeToV0_48(HandleRef pThis);

	/// <summary>
	/// Get/Set the mode used for the scalar data.
	/// See SCALAR_MODE for a description of the types of scalars generated.
	/// </summary>
	public void SetScalarModeToV0()
	{
		vtkParametricFunctionSource_SetScalarModeToV0_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunctionSource_SetScalarModeToX_49(HandleRef pThis);

	/// <summary>
	/// Get/Set the mode used for the scalar data.
	/// See SCALAR_MODE for a description of the types of scalars generated.
	/// </summary>
	public void SetScalarModeToX()
	{
		vtkParametricFunctionSource_SetScalarModeToX_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunctionSource_SetScalarModeToY_50(HandleRef pThis);

	/// <summary>
	/// Get/Set the mode used for the scalar data.
	/// See SCALAR_MODE for a description of the types of scalars generated.
	/// </summary>
	public void SetScalarModeToY()
	{
		vtkParametricFunctionSource_SetScalarModeToY_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunctionSource_SetScalarModeToZ_51(HandleRef pThis);

	/// <summary>
	/// Get/Set the mode used for the scalar data.
	/// See SCALAR_MODE for a description of the types of scalars generated.
	/// </summary>
	public void SetScalarModeToZ()
	{
		vtkParametricFunctionSource_SetScalarModeToZ_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunctionSource_SetUResolution_52(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the number of subdivisions / tessellations in the u parametric
	/// direction. Note that the number of tessellant points in the u
	/// direction is the UResolution + 1.
	/// </summary>
	public virtual void SetUResolution(int _arg)
	{
		vtkParametricFunctionSource_SetUResolution_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunctionSource_SetVResolution_53(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the number of subdivisions / tessellations in the v parametric
	/// direction. Note that the number of tessellant points in the v
	/// direction is the VResolution + 1.
	/// </summary>
	public virtual void SetVResolution(int _arg)
	{
		vtkParametricFunctionSource_SetVResolution_53(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParametricFunctionSource_SetWResolution_54(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the number of subdivisions / tessellations in the w parametric
	/// direction. Note that the number of tessellant points in the w
	/// direction is the WResolution + 1.
	/// </summary>
	public virtual void SetWResolution(int _arg)
	{
		vtkParametricFunctionSource_SetWResolution_54(GetCppThis(), _arg);
	}
}
