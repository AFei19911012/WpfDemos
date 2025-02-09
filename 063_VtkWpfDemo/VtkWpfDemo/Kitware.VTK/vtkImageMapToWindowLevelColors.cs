using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageMapToWindowLevelColors
/// </summary>
/// <remarks>
///    Map an image through a lookup table and/or a window/level.
///
/// The vtkImageMapToWindowLevelColors filter can be used to perform
/// the following operations depending on its settings:
/// -# If no lookup table is provided, and if the input data has a single
///    component (any numerical scalar type is allowed), then the data is
///    mapped through the specified Window/Level.  The type of the output
///    scalars will be "unsigned char" with a range of (0,255).
/// -# If no lookup table is provided, and if the input data is already
///    unsigned char, and if the Window/Level is set to 255.0/127.5, then
///    the input data will be passed directly to the output.
/// -# If a lookup table is provided, then the first component of the
///    input data is mapped through the lookup table (using the Range of
///    the lookup table), and the resulting color is modulated according
///    to the Window/Level.  For example, if the input value is 500 and
///    the Window/Level are 2000/1000, the output value will be RGB*0.25
///    where RGB is the color assigned by the lookup table and 0.25 is
///    the modulation factor.
/// See SetWindow() and SetLevel() for the equations used for modulation.
/// To map scalars through a lookup table without modulating the resulting
/// color, use vtkImageMapToColors instead of this filter.
/// </remarks>
/// <seealso>
///
/// vtkLookupTable vtkScalarsToColors
/// </seealso>
public class vtkImageMapToWindowLevelColors : vtkImageMapToColors
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageMapToWindowLevelColors";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageMapToWindowLevelColors()
	{
		MRClassNameKey = "class vtkImageMapToWindowLevelColors";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMapToWindowLevelColors"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageMapToWindowLevelColors(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMapToWindowLevelColors_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageMapToWindowLevelColors New()
	{
		vtkImageMapToWindowLevelColors result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMapToWindowLevelColors_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageMapToWindowLevelColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageMapToWindowLevelColors()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageMapToWindowLevelColors_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageMapToWindowLevelColors_GetLevel_01(HandleRef pThis);

	/// <summary>
	/// Set / Get the Level to use -&gt; modulation will be performed on the
	/// color based on (S - (L - W/2))/W where S is the scalar value, L is
	/// the level and W is the window.
	/// </summary>
	public virtual double GetLevel()
	{
		return vtkImageMapToWindowLevelColors_GetLevel_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageMapToWindowLevelColors_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageMapToWindowLevelColors_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageMapToWindowLevelColors_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageMapToWindowLevelColors_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageMapToWindowLevelColors_GetWindow_04(HandleRef pThis);

	/// <summary>
	/// Set / Get the Window to use -&gt; modulation will be performed on the
	/// color based on (S - (L - W/2))/W where S is the scalar value, L is
	/// the level and W is the window.
	/// </summary>
	public virtual double GetWindow()
	{
		return vtkImageMapToWindowLevelColors_GetWindow_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMapToWindowLevelColors_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageMapToWindowLevelColors_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMapToWindowLevelColors_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageMapToWindowLevelColors_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMapToWindowLevelColors_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageMapToWindowLevelColors NewInstance()
	{
		vtkImageMapToWindowLevelColors result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMapToWindowLevelColors_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageMapToWindowLevelColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMapToWindowLevelColors_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageMapToWindowLevelColors SafeDownCast(vtkObjectBase o)
	{
		vtkImageMapToWindowLevelColors vtkImageMapToWindowLevelColors2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMapToWindowLevelColors_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageMapToWindowLevelColors2 = (vtkImageMapToWindowLevelColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageMapToWindowLevelColors2.Register(null);
			}
		}
		return vtkImageMapToWindowLevelColors2;
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapToWindowLevelColors_SetLevel_10(HandleRef pThis, double _arg);

	/// <summary>
	/// Set / Get the Level to use -&gt; modulation will be performed on the
	/// color based on (S - (L - W/2))/W where S is the scalar value, L is
	/// the level and W is the window.
	/// </summary>
	public virtual void SetLevel(double _arg)
	{
		vtkImageMapToWindowLevelColors_SetLevel_10(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMapToWindowLevelColors_SetWindow_11(HandleRef pThis, double _arg);

	/// <summary>
	/// Set / Get the Window to use -&gt; modulation will be performed on the
	/// color based on (S - (L - W/2))/W where S is the scalar value, L is
	/// the level and W is the window.
	/// </summary>
	public virtual void SetWindow(double _arg)
	{
		vtkImageMapToWindowLevelColors_SetWindow_11(GetCppThis(), _arg);
	}
}
