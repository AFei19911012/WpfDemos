using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkKMeansDistanceFunctorCalculator
/// </summary>
/// <remarks>
///    measure distance from k-means cluster centers using a user-specified expression
///
/// This is a subclass of the default k-means distance functor that allows
/// the user to specify a distance function as a string. The provided
/// expression is evaluated whenever the parenthesis operator is invoked
/// but this is much slower than the default distance calculation.
///
/// User-specified distance expressions should be written in terms of
/// two vector variables named "x" and "y".
/// The length of the vectors will be determined by the k-means request
/// and all columns of interest in the request must contain values that
/// may be converted to a floating point representation. (Strings and
/// vtkObject pointers are not allowed.)
/// An example distance expression is "sqrt( (x0-y0)^2 + (x1-y1)^2 )"
/// which computes Euclidean distance in a plane defined by the first
/// 2 coordinates of the vectors specified.
/// </remarks>
public class vtkKMeansDistanceFunctorCalculator : vtkKMeansDistanceFunctor
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkKMeansDistanceFunctorCalculator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkKMeansDistanceFunctorCalculator()
	{
		MRClassNameKey = "class vtkKMeansDistanceFunctorCalculator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkKMeansDistanceFunctorCalculator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkKMeansDistanceFunctorCalculator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKMeansDistanceFunctorCalculator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkKMeansDistanceFunctorCalculator New()
	{
		vtkKMeansDistanceFunctorCalculator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKMeansDistanceFunctorCalculator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkKMeansDistanceFunctorCalculator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkKMeansDistanceFunctorCalculator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkKMeansDistanceFunctorCalculator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKMeansDistanceFunctorCalculator_GetDistanceExpression_01(HandleRef pThis);

	/// <summary>
	/// Set/get the distance function expression.
	/// </summary>
	public virtual string GetDistanceExpression()
	{
		return Marshal.PtrToStringAnsi(vtkKMeansDistanceFunctorCalculator_GetDistanceExpression_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKMeansDistanceFunctorCalculator_GetFunctionParser_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/get the string containing an expression which evaluates to the
	/// distance metric used for k-means computation. The scalar variables
	/// "x0", "x1", ... "xn" and "y0", "y1", ..., "yn" refer to the coordinates
	/// involved in the computation.
	/// </summary>
	public virtual vtkFunctionParser GetFunctionParser()
	{
		vtkFunctionParser vtkFunctionParser2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKMeansDistanceFunctorCalculator_GetFunctionParser_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFunctionParser2 = (vtkFunctionParser)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFunctionParser2.Register(null);
			}
		}
		return vtkFunctionParser2;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkKMeansDistanceFunctorCalculator_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkKMeansDistanceFunctorCalculator_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkKMeansDistanceFunctorCalculator_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkKMeansDistanceFunctorCalculator_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKMeansDistanceFunctorCalculator_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkKMeansDistanceFunctorCalculator_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKMeansDistanceFunctorCalculator_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkKMeansDistanceFunctorCalculator_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKMeansDistanceFunctorCalculator_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkKMeansDistanceFunctorCalculator NewInstance()
	{
		vtkKMeansDistanceFunctorCalculator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKMeansDistanceFunctorCalculator_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkKMeansDistanceFunctorCalculator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKMeansDistanceFunctorCalculator_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkKMeansDistanceFunctorCalculator SafeDownCast(vtkObjectBase o)
	{
		vtkKMeansDistanceFunctorCalculator vtkKMeansDistanceFunctorCalculator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKMeansDistanceFunctorCalculator_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkKMeansDistanceFunctorCalculator2 = (vtkKMeansDistanceFunctorCalculator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkKMeansDistanceFunctorCalculator2.Register(null);
			}
		}
		return vtkKMeansDistanceFunctorCalculator2;
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKMeansDistanceFunctorCalculator_SetDistanceExpression_10(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/get the distance function expression.
	/// </summary>
	public virtual void SetDistanceExpression(string _arg)
	{
		vtkKMeansDistanceFunctorCalculator_SetDistanceExpression_10(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersStatistics.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKMeansDistanceFunctorCalculator_SetFunctionParser_11(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/get the string containing an expression which evaluates to the
	/// distance metric used for k-means computation. The scalar variables
	/// "x0", "x1", ... "xn" and "y0", "y1", ..., "yn" refer to the coordinates
	/// involved in the computation.
	/// </summary>
	public virtual void SetFunctionParser(vtkFunctionParser arg0)
	{
		vtkKMeansDistanceFunctorCalculator_SetFunctionParser_11(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
