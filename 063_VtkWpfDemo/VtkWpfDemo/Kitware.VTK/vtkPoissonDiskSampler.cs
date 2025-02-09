using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPoissonDiskSampler
/// </summary>
/// <remarks>
///    generate point normals using local tangent planes
///
///
/// vtkPoissonDiskSampler performs a poisson disk sampling on the input. It takes any `vtkPointSet`
/// as input and produces a `vtkPointSet`. If the input has cells (typically if the input is a
/// `vtkPolyData` or a `vtkUnstructuredGrid`), cells are removed in the output point set.
///
/// PoissonDisk sampling is done by doing "dart throwing". It is very similar to the implementation
/// proposed by &lt;a
/// href="http://citeseerx.ist.psu.edu/viewdoc/download?doi=10.1.1.476.9482&amp;rep=rep1&amp;type=pdf"&gt;
/// Dipp\'e and Wold in 1986&lt;/a&gt;. Points are drawn randomly one by one and added
/// in the output. Points within a range of `Radius` (input parameter) are discarded from the
/// output. This process is repeated until there are no more points unprocessed.
/// </remarks>
public class vtkPoissonDiskSampler : vtkPointSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPoissonDiskSampler";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPoissonDiskSampler()
	{
		MRClassNameKey = "class vtkPoissonDiskSampler";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPoissonDiskSampler"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPoissonDiskSampler(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPoissonDiskSampler_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static vtkPoissonDiskSampler New()
	{
		vtkPoissonDiskSampler result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPoissonDiskSampler_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPoissonDiskSampler)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public vtkPoissonDiskSampler()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPoissonDiskSampler_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPoissonDiskSampler_GetLocator_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a point locator. By default a vtkKdTreePointLocator is
	/// used. The locator performs efficient searches to locate points
	/// around a sample point.
	/// </summary>
	public virtual vtkAbstractPointLocator GetLocator()
	{
		vtkAbstractPointLocator vtkAbstractPointLocator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPoissonDiskSampler_GetLocator_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractPointLocator2 = (vtkAbstractPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractPointLocator2.Register(null);
			}
		}
		return vtkAbstractPointLocator2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPoissonDiskSampler_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPoissonDiskSampler_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPoissonDiskSampler_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPoissonDiskSampler_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPoissonDiskSampler_GetRadius_04(HandleRef pThis);

	/// <summary>
	/// Setter / Getter for `Radius`. It is used to determinate the minimum distance that there should
	/// be between 2 nearest points in the output.
	/// </summary>
	public virtual double GetRadius()
	{
		return vtkPoissonDiskSampler_GetRadius_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPoissonDiskSampler_IsA_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPoissonDiskSampler_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPoissonDiskSampler_IsTypeOf_06(string type);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPoissonDiskSampler_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPoissonDiskSampler_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new vtkPoissonDiskSampler NewInstance()
	{
		vtkPoissonDiskSampler result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPoissonDiskSampler_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPoissonDiskSampler)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPoissonDiskSampler_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiating, obtaining type information, and
	/// printing information.
	/// </summary>
	public new static vtkPoissonDiskSampler SafeDownCast(vtkObjectBase o)
	{
		vtkPoissonDiskSampler vtkPoissonDiskSampler2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPoissonDiskSampler_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPoissonDiskSampler2 = (vtkPoissonDiskSampler)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPoissonDiskSampler2.Register(null);
			}
		}
		return vtkPoissonDiskSampler2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoissonDiskSampler_SetLocator_10(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Specify a point locator. By default a vtkKdTreePointLocator is
	/// used. The locator performs efficient searches to locate points
	/// around a sample point.
	/// </summary>
	public void SetLocator(vtkAbstractPointLocator locator)
	{
		vtkPoissonDiskSampler_SetLocator_10(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPoissonDiskSampler_SetRadius_11(HandleRef pThis, double _arg);

	/// <summary>
	/// Setter / Getter for `Radius`. It is used to determinate the minimum distance that there should
	/// be between 2 nearest points in the output.
	/// </summary>
	public virtual void SetRadius(double _arg)
	{
		vtkPoissonDiskSampler_SetRadius_11(GetCppThis(), _arg);
	}
}
