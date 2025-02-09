using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageDataOutlineFilter
/// </summary>
/// <remarks>
///    create wireframe outline for a possibly oriented vtkImageData
///
/// vtkImageDataOutlineFilter is a filter that generates a wireframe outline
/// of vtkImageData. It takes into account the orientation / DirectionMatrix
/// of the image, so the output outline may not be axes aligned.  The outline
/// consists of the twelve edges of the vtkImageData. Optionally, the six
/// bounding faces of the vtkImageData can be produced as well.
///
/// </remarks>
/// <seealso>
///
/// vtkOutlineFilter
/// </seealso>
public class vtkImageDataOutlineFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageDataOutlineFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageDataOutlineFilter()
	{
		MRClassNameKey = "class vtkImageDataOutlineFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageDataOutlineFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageDataOutlineFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageDataOutlineFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation. type information, and printing.
	/// </summary>
	public new static vtkImageDataOutlineFilter New()
	{
		vtkImageDataOutlineFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageDataOutlineFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageDataOutlineFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation. type information, and printing.
	/// </summary>
	public vtkImageDataOutlineFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageDataOutlineFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDataOutlineFilter_GenerateFacesOff_01(HandleRef pThis);

	/// <summary>
	/// Generate the six boundary faces of the image data. This is off by default.
	/// </summary>
	public virtual void GenerateFacesOff()
	{
		vtkImageDataOutlineFilter_GenerateFacesOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDataOutlineFilter_GenerateFacesOn_02(HandleRef pThis);

	/// <summary>
	/// Generate the six boundary faces of the image data. This is off by default.
	/// </summary>
	public virtual void GenerateFacesOn()
	{
		vtkImageDataOutlineFilter_GenerateFacesOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageDataOutlineFilter_GetGenerateFaces_03(HandleRef pThis);

	/// <summary>
	/// Generate the six boundary faces of the image data. This is off by default.
	/// </summary>
	public virtual int GetGenerateFaces()
	{
		return vtkImageDataOutlineFilter_GetGenerateFaces_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageDataOutlineFilter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation. type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageDataOutlineFilter_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageDataOutlineFilter_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	/// Standard methods for instantiation. type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageDataOutlineFilter_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageDataOutlineFilter_GetOutputPointsPrecision_06(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkImageDataOutlineFilter_GetOutputPointsPrecision_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageDataOutlineFilter_IsA_07(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation. type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageDataOutlineFilter_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageDataOutlineFilter_IsTypeOf_08(string type);

	/// <summary>
	/// Standard methods for instantiation. type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageDataOutlineFilter_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageDataOutlineFilter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation. type information, and printing.
	/// </summary>
	public new vtkImageDataOutlineFilter NewInstance()
	{
		vtkImageDataOutlineFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageDataOutlineFilter_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageDataOutlineFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageDataOutlineFilter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation. type information, and printing.
	/// </summary>
	public new static vtkImageDataOutlineFilter SafeDownCast(vtkObjectBase o)
	{
		vtkImageDataOutlineFilter vtkImageDataOutlineFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageDataOutlineFilter_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageDataOutlineFilter2 = (vtkImageDataOutlineFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageDataOutlineFilter2.Register(null);
			}
		}
		return vtkImageDataOutlineFilter2;
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDataOutlineFilter_SetGenerateFaces_12(HandleRef pThis, int _arg);

	/// <summary>
	/// Generate the six boundary faces of the image data. This is off by default.
	/// </summary>
	public virtual void SetGenerateFaces(int _arg)
	{
		vtkImageDataOutlineFilter_SetGenerateFaces_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDataOutlineFilter_SetOutputPointsPrecision_13(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkImageDataOutlineFilter_SetOutputPointsPrecision_13(GetCppThis(), _arg);
	}
}
