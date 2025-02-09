using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkUnstructuredGridPartialPreIntegration
/// </summary>
/// <remarks>
///    performs piecewise linear ray integration.
///
///
///
/// vtkUnstructuredGridPartialPreIntegration performs piecewise linear ray
/// integration.  This will give the same results as
/// vtkUnstructuredGridLinearRayIntegration (with potentially a error due to
/// table lookup quantization), but should be notably faster.  The algorithm
/// used is given by Moreland and Angel, "A Fast High Accuracy Volume
/// Renderer for Unstructured Data."
///
/// This class is thread safe only after the first instance is created.
///
/// </remarks>
public class vtkUnstructuredGridPartialPreIntegration : vtkUnstructuredGridVolumeRayIntegrator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridPartialPreIntegration";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkUnstructuredGridPartialPreIntegration()
	{
		MRClassNameKey = "class vtkUnstructuredGridPartialPreIntegration";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridPartialPreIntegration"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkUnstructuredGridPartialPreIntegration(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridPartialPreIntegration_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkUnstructuredGridPartialPreIntegration New()
	{
		vtkUnstructuredGridPartialPreIntegration result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridPartialPreIntegration_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUnstructuredGridPartialPreIntegration)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkUnstructuredGridPartialPreIntegration()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkUnstructuredGridPartialPreIntegration_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkUnstructuredGridPartialPreIntegration_BuildPsiTable_01();

	/// <summary>
	/// Looks up Psi (as defined by Moreland and Angel, "A Fast High Accuracy
	/// Volume Renderer for Unstructured Data") in a table.  The table must be
	/// created first, which happens on the first instantiation of this class
	/// or when BuildPsiTable is first called.
	/// </summary>
	public static void BuildPsiTable()
	{
		vtkUnstructuredGridPartialPreIntegration_BuildPsiTable_01();
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridPartialPreIntegration_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkUnstructuredGridPartialPreIntegration_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridPartialPreIntegration_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkUnstructuredGridPartialPreIntegration_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridPartialPreIntegration_GetPsiTable_04(ref int size);

	/// <summary>
	/// Looks up Psi (as defined by Moreland and Angel, "A Fast High Accuracy
	/// Volume Renderer for Unstructured Data") in a table.  The table must be
	/// created first, which happens on the first instantiation of this class
	/// or when BuildPsiTable is first called.
	/// </summary>
	public static IntPtr GetPsiTable(ref int size)
	{
		return vtkUnstructuredGridPartialPreIntegration_GetPsiTable_04(ref size);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridPartialPreIntegration_Initialize_05(HandleRef pThis, HandleRef volume, HandleRef scalars);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void Initialize(vtkVolume volume, vtkDataArray scalars)
	{
		vtkUnstructuredGridPartialPreIntegration_Initialize_05(GetCppThis(), volume?.GetCppThis() ?? default(HandleRef), scalars?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridPartialPreIntegration_Integrate_06(HandleRef pThis, HandleRef intersectionLengths, HandleRef nearIntersections, HandleRef farIntersections, IntPtr color);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void Integrate(vtkDoubleArray intersectionLengths, vtkDataArray nearIntersections, vtkDataArray farIntersections, IntPtr color)
	{
		vtkUnstructuredGridPartialPreIntegration_Integrate_06(GetCppThis(), intersectionLengths?.GetCppThis() ?? default(HandleRef), nearIntersections?.GetCppThis() ?? default(HandleRef), farIntersections?.GetCppThis() ?? default(HandleRef), color);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridPartialPreIntegration_IntegrateRay_07(double length, double intensity_front, double attenuation_front, double intensity_back, double attenuation_back, IntPtr color);

	/// <summary>
	/// Integrates a single ray segment.  \c color is blended with the result
	/// (with \c color in front).  The result is written back into \c color.
	/// </summary>
	public static void IntegrateRay(double length, double intensity_front, double attenuation_front, double intensity_back, double attenuation_back, IntPtr color)
	{
		vtkUnstructuredGridPartialPreIntegration_IntegrateRay_07(length, intensity_front, attenuation_front, intensity_back, attenuation_back, color);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridPartialPreIntegration_IntegrateRay_08(double length, IntPtr color_front, double attenuation_front, IntPtr color_back, double attenuation_back, IntPtr color);

	/// <summary>
	/// Integrates a single ray segment.  \c color is blended with the result
	/// (with \c color in front).  The result is written back into \c color.
	/// </summary>
	public static void IntegrateRay(double length, IntPtr color_front, double attenuation_front, IntPtr color_back, double attenuation_back, IntPtr color)
	{
		vtkUnstructuredGridPartialPreIntegration_IntegrateRay_08(length, color_front, attenuation_front, color_back, attenuation_back, color);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridPartialPreIntegration_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkUnstructuredGridPartialPreIntegration_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridPartialPreIntegration_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkUnstructuredGridPartialPreIntegration_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridPartialPreIntegration_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkUnstructuredGridPartialPreIntegration NewInstance()
	{
		vtkUnstructuredGridPartialPreIntegration result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridPartialPreIntegration_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUnstructuredGridPartialPreIntegration)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkUnstructuredGridPartialPreIntegration_Psi_13(float taufD, float taubD);

	/// <summary>
	/// Looks up Psi (as defined by Moreland and Angel, "A Fast High Accuracy
	/// Volume Renderer for Unstructured Data") in a table.  The table must be
	/// created first, which happens on the first instantiation of this class
	/// or when BuildPsiTable is first called.
	/// </summary>
	public static float Psi(float taufD, float taubD)
	{
		return vtkUnstructuredGridPartialPreIntegration_Psi_13(taufD, taubD);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridPartialPreIntegration_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkUnstructuredGridPartialPreIntegration SafeDownCast(vtkObjectBase o)
	{
		vtkUnstructuredGridPartialPreIntegration vtkUnstructuredGridPartialPreIntegration2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridPartialPreIntegration_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGridPartialPreIntegration2 = (vtkUnstructuredGridPartialPreIntegration)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGridPartialPreIntegration2.Register(null);
			}
		}
		return vtkUnstructuredGridPartialPreIntegration2;
	}
}
