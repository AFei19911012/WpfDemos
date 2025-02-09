using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAbstractSplineRepresentation
/// </summary>
/// <remarks>
///    abstract representation for a spline.
///
/// vtkAbstractSplineRepresentation is a vtkWidgetRepresentation for an abstract spline.
/// This 3D widget defines a spline that can be accessed, set and configured.
/// Deriving classes are then able to combine their own handles using this class.
/// </remarks>
public abstract class vtkAbstractSplineRepresentation : vtkCurveRepresentation
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractSplineRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAbstractSplineRepresentation()
	{
		MRClassNameKey = "class vtkAbstractSplineRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractSplineRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAbstractSplineRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	/// <summary>
	/// Automatically generated protected Dispose method - called from
	/// public Dispose or the C# destructor. DO NOT call directly.
	/// </summary>
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractSplineRepresentation_GetHandlePositions_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the position of the spline handles.
	/// </summary>
	public override vtkDoubleArray GetHandlePositions()
	{
		vtkDoubleArray vtkDoubleArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractSplineRepresentation_GetHandlePositions_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDoubleArray2 = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDoubleArray2.Register(null);
			}
		}
		return vtkDoubleArray2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractSplineRepresentation_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAbstractSplineRepresentation_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAbstractSplineRepresentation_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAbstractSplineRepresentation_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractSplineRepresentation_GetParametricSpline_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the parametric spline object.
	/// Can be redefined in the child classes for further updates
	/// when a spline is set.
	/// The default value is nullptr.
	/// </summary>
	public virtual vtkParametricSpline GetParametricSpline()
	{
		vtkParametricSpline vtkParametricSpline2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractSplineRepresentation_GetParametricSpline_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkParametricSpline2 = (vtkParametricSpline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkParametricSpline2.Register(null);
			}
		}
		return vtkParametricSpline2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractSplineRepresentation_GetPolyData_05(HandleRef pThis, HandleRef pd);

	/// <summary>
	/// Grab the polydata (including points) that defines the spline.  The
	/// polydata consists of points and line segments numbering Resolution + 1
	/// and Resolution, respectively. Points are guaranteed to be up-to-date when
	/// either the InteractionEvent or EndInteraction events are invoked. The
	/// user provides the vtkPolyData and the points and polyline are added to it.
	/// </summary>
	public override void GetPolyData(vtkPolyData pd)
	{
		vtkAbstractSplineRepresentation_GetPolyData_05(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractSplineRepresentation_GetResolution_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of line segments representing the spline for
	/// this widget.
	/// The default value is 499.
	/// </summary>
	public virtual int GetResolution()
	{
		return vtkAbstractSplineRepresentation_GetResolution_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAbstractSplineRepresentation_GetSummedLength_07(HandleRef pThis);

	/// <summary>
	/// Get the approximate vs. the true arc length of the spline. Calculated as
	/// the summed lengths of the individual straight line segments. Use
	/// SetResolution to control the accuracy.
	/// </summary>
	public override double GetSummedLength()
	{
		return vtkAbstractSplineRepresentation_GetSummedLength_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractSplineRepresentation_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAbstractSplineRepresentation_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAbstractSplineRepresentation_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAbstractSplineRepresentation_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractSplineRepresentation_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAbstractSplineRepresentation NewInstance()
	{
		vtkAbstractSplineRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractSplineRepresentation_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAbstractSplineRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAbstractSplineRepresentation_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAbstractSplineRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkAbstractSplineRepresentation vtkAbstractSplineRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAbstractSplineRepresentation_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractSplineRepresentation2 = (vtkAbstractSplineRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractSplineRepresentation2.Register(null);
			}
		}
		return vtkAbstractSplineRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractSplineRepresentation_SetParametricSpline_12(HandleRef pThis, HandleRef spline);

	/// <summary>
	/// Set the parametric spline object.
	/// Can be redefined in the child classes for further updates
	/// when a spline is set.
	/// The default value is nullptr.
	/// </summary>
	public virtual void SetParametricSpline(vtkParametricSpline spline)
	{
		vtkAbstractSplineRepresentation_SetParametricSpline_12(GetCppThis(), spline?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAbstractSplineRepresentation_SetResolution_13(HandleRef pThis, int resolution);

	/// <summary>
	/// Set/Get the number of line segments representing the spline for
	/// this widget.
	/// The default value is 499.
	/// </summary>
	public void SetResolution(int resolution)
	{
		vtkAbstractSplineRepresentation_SetResolution_13(GetCppThis(), resolution);
	}
}
