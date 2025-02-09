using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkUnstructuredGridLinearRayIntegrator
/// </summary>
/// <remarks>
///    performs piecewise linear ray integration.
///
///
///
/// vtkUnstructuredGridLinearRayIntegrator performs piecewise linear ray
/// integration.  Considering that transfer functions in VTK are piecewise
/// linear, this class should give the "correct" integration under most
/// circumstances.  However, the computations performed are fairly hefty and
/// should, for the most part, only be used as a benchmark for other, faster
/// methods.
///
/// </remarks>
/// <seealso>
///
/// vtkUnstructuredGridPartialPreIntegration
///
/// </seealso>
public class vtkUnstructuredGridLinearRayIntegrator : vtkUnstructuredGridVolumeRayIntegrator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridLinearRayIntegrator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkUnstructuredGridLinearRayIntegrator()
	{
		MRClassNameKey = "class vtkUnstructuredGridLinearRayIntegrator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridLinearRayIntegrator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkUnstructuredGridLinearRayIntegrator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridLinearRayIntegrator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkUnstructuredGridLinearRayIntegrator New()
	{
		vtkUnstructuredGridLinearRayIntegrator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridLinearRayIntegrator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUnstructuredGridLinearRayIntegrator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkUnstructuredGridLinearRayIntegrator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkUnstructuredGridLinearRayIntegrator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridLinearRayIntegrator_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkUnstructuredGridLinearRayIntegrator_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridLinearRayIntegrator_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkUnstructuredGridLinearRayIntegrator_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridLinearRayIntegrator_Initialize_03(HandleRef pThis, HandleRef volume, HandleRef scalars);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void Initialize(vtkVolume volume, vtkDataArray scalars)
	{
		vtkUnstructuredGridLinearRayIntegrator_Initialize_03(GetCppThis(), volume?.GetCppThis() ?? default(HandleRef), scalars?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridLinearRayIntegrator_Integrate_04(HandleRef pThis, HandleRef intersectionLengths, HandleRef nearIntersections, HandleRef farIntersections, IntPtr color);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void Integrate(vtkDoubleArray intersectionLengths, vtkDataArray nearIntersections, vtkDataArray farIntersections, IntPtr color)
	{
		vtkUnstructuredGridLinearRayIntegrator_Integrate_04(GetCppThis(), intersectionLengths?.GetCppThis() ?? default(HandleRef), nearIntersections?.GetCppThis() ?? default(HandleRef), farIntersections?.GetCppThis() ?? default(HandleRef), color);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridLinearRayIntegrator_IntegrateRay_05(double length, double intensity_front, double attenuation_front, double intensity_back, double attenuation_back, IntPtr color);

	/// <summary>
	/// Integrates a single ray segment.  \c color is blended with the result
	/// (with \c color in front).  The result is written back into \c color.
	/// </summary>
	public static void IntegrateRay(double length, double intensity_front, double attenuation_front, double intensity_back, double attenuation_back, IntPtr color)
	{
		vtkUnstructuredGridLinearRayIntegrator_IntegrateRay_05(length, intensity_front, attenuation_front, intensity_back, attenuation_back, color);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridLinearRayIntegrator_IntegrateRay_06(double length, IntPtr color_front, double attenuation_front, IntPtr color_back, double attenuation_back, IntPtr color);

	/// <summary>
	/// Integrates a single ray segment.  \c color is blended with the result
	/// (with \c color in front).  The result is written back into \c color.
	/// </summary>
	public static void IntegrateRay(double length, IntPtr color_front, double attenuation_front, IntPtr color_back, double attenuation_back, IntPtr color)
	{
		vtkUnstructuredGridLinearRayIntegrator_IntegrateRay_06(length, color_front, attenuation_front, color_back, attenuation_back, color);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridLinearRayIntegrator_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkUnstructuredGridLinearRayIntegrator_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridLinearRayIntegrator_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkUnstructuredGridLinearRayIntegrator_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridLinearRayIntegrator_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkUnstructuredGridLinearRayIntegrator NewInstance()
	{
		vtkUnstructuredGridLinearRayIntegrator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridLinearRayIntegrator_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUnstructuredGridLinearRayIntegrator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkUnstructuredGridLinearRayIntegrator_Psi_11(float length, float attenuation_front, float attenuation_back);

	/// <summary>
	/// Computes Psi (as defined by Moreland and Angel, "A Fast High Accuracy
	/// Volume Renderer for Unstructured Data").
	/// </summary>
	public static float Psi(float length, float attenuation_front, float attenuation_back)
	{
		return vtkUnstructuredGridLinearRayIntegrator_Psi_11(length, attenuation_front, attenuation_back);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridLinearRayIntegrator_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkUnstructuredGridLinearRayIntegrator SafeDownCast(vtkObjectBase o)
	{
		vtkUnstructuredGridLinearRayIntegrator vtkUnstructuredGridLinearRayIntegrator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridLinearRayIntegrator_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGridLinearRayIntegrator2 = (vtkUnstructuredGridLinearRayIntegrator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGridLinearRayIntegrator2.Register(null);
			}
		}
		return vtkUnstructuredGridLinearRayIntegrator2;
	}
}
