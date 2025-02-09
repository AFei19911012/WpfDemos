using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkContourValues
/// </summary>
/// <remarks>
///    helper object to manage setting and generating contour values
///
/// vtkContourValues is a general class to manage the creation, generation,
/// and retrieval of contour values. This class serves as a helper class for
/// contouring classes, or those classes operating on lists of contour values.
///
/// </remarks>
/// <seealso>
///
/// vtkContourFilter
/// </seealso>
public class vtkContourValues : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkContourValues";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkContourValues()
	{
		MRClassNameKey = "class vtkContourValues";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkContourValues"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkContourValues(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourValues_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with a single contour value at 0.0.
	/// </summary>
	public new static vtkContourValues New()
	{
		vtkContourValues result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContourValues_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkContourValues)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with a single contour value at 0.0.
	/// </summary>
	public vtkContourValues()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkContourValues_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourValues_DeepCopy_01(HandleRef pThis, HandleRef other);

	/// <summary>
	/// Copy contours.
	/// </summary>
	public void DeepCopy(vtkContourValues other)
	{
		vtkContourValues_DeepCopy_01(GetCppThis(), other?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourValues_GenerateValues_02(HandleRef pThis, int numContours, IntPtr range);

	/// <summary>
	/// Generate numContours equally spaced contour values between specified
	/// range. Contour values will include min/max range values.
	/// </summary>
	public void GenerateValues(int numContours, IntPtr range)
	{
		vtkContourValues_GenerateValues_02(GetCppThis(), numContours, range);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourValues_GenerateValues_03(HandleRef pThis, int numContours, double rangeStart, double rangeEnd);

	/// <summary>
	/// Generate numContours equally spaced contour values between specified
	/// range. Contour values will include min/max range values.
	/// </summary>
	public void GenerateValues(int numContours, double rangeStart, double rangeEnd)
	{
		vtkContourValues_GenerateValues_03(GetCppThis(), numContours, rangeStart, rangeEnd);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourValues_GetNumberOfContours_04(HandleRef pThis);

	/// <summary>
	/// Return the number of contours in the
	/// </summary>
	public int GetNumberOfContours()
	{
		return vtkContourValues_GetNumberOfContours_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContourValues_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	/// Construct object with a single contour value at 0.0.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkContourValues_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContourValues_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	/// Construct object with a single contour value at 0.0.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkContourValues_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkContourValues_GetValue_07(HandleRef pThis, int i);

	/// <summary>
	/// Get the ith contour value. The return value will be clamped if the
	/// index i is out of range.
	/// </summary>
	public double GetValue(int i)
	{
		return vtkContourValues_GetValue_07(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourValues_GetValues_08(HandleRef pThis);

	/// <summary>
	/// Return a pointer to a list of contour values. The contents of the
	/// list will be garbage if the number of contours &lt;= 0.
	/// </summary>
	public IntPtr GetValues()
	{
		return vtkContourValues_GetValues_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourValues_GetValues_09(HandleRef pThis, IntPtr contourValues);

	/// <summary>
	/// Fill a supplied list with contour values. Make sure you've
	/// allocated memory of size GetNumberOfContours().
	/// </summary>
	public void GetValues(IntPtr contourValues)
	{
		vtkContourValues_GetValues_09(GetCppThis(), contourValues);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourValues_IsA_10(HandleRef pThis, string type);

	/// <summary>
	/// Construct object with a single contour value at 0.0.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkContourValues_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourValues_IsTypeOf_11(string type);

	/// <summary>
	/// Construct object with a single contour value at 0.0.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkContourValues_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourValues_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with a single contour value at 0.0.
	/// </summary>
	public new vtkContourValues NewInstance()
	{
		vtkContourValues result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContourValues_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkContourValues)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourValues_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with a single contour value at 0.0.
	/// </summary>
	public new static vtkContourValues SafeDownCast(vtkObjectBase o)
	{
		vtkContourValues vtkContourValues2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContourValues_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkContourValues2 = (vtkContourValues)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkContourValues2.Register(null);
			}
		}
		return vtkContourValues2;
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourValues_SetNumberOfContours_15(HandleRef pThis, int number);

	/// <summary>
	/// Set the number of contours to place into the list. You only really
	/// need to use this method to reduce list size. The method SetValue()
	/// will automatically increase list size as needed.
	/// </summary>
	public void SetNumberOfContours(int number)
	{
		vtkContourValues_SetNumberOfContours_15(GetCppThis(), number);
	}

	[DllImport("Kitware.VTK.CommonMisc.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourValues_SetValue_16(HandleRef pThis, int i, double value);

	/// <summary>
	/// Set the ith contour value.
	/// </summary>
	public void SetValue(int i, double value)
	{
		vtkContourValues_SetValue_16(GetCppThis(), i, value);
	}
}
