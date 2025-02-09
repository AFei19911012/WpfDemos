using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCameraPathRepresentation
/// </summary>
/// <remarks>
///    representation for a camera path.
///
/// vtkCameraPathRepresentation is a vtkWidgetRepresentation for a camera path.
/// This 3D widget defines a camera path that can be interactively manipulated in a
/// scene. The camera path has camera handles, that can be added and deleted, plus they
/// can be picked on the path itself to be translated in the scene.
/// This representation is used with vtkCameraPathWidget.
/// </remarks>
/// <seealso>
///
/// vtkCameraPathWidget
/// </seealso>
public class vtkCameraPathRepresentation : vtkAbstractSplineRepresentation
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCameraPathRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCameraPathRepresentation()
	{
		MRClassNameKey = "class vtkCameraPathRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCameraPathRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCameraPathRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraPathRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCameraPathRepresentation New()
	{
		vtkCameraPathRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCameraPathRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCameraPathRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCameraPathRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCameraPathRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraPathRepresentation_AddCameraAt_01(HandleRef pThis, HandleRef camera, int index);

	/// <summary>
	/// Add a camera to the path.
	/// </summary>
	public void AddCameraAt(vtkCamera camera, int index)
	{
		vtkCameraPathRepresentation_AddCameraAt_01(GetCppThis(), camera?.GetCppThis() ?? default(HandleRef), index);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraPathRepresentation_BuildRepresentation_02(HandleRef pThis);

	/// <summary>
	/// Method that satisfy vtkWidgetRepresentation API.
	/// Updates the spline in relation with the handles positions
	/// and updates vtkWidgetRepresentation::InitialLength
	/// (useful for the sizing methods).
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkCameraPathRepresentation_BuildRepresentation_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraPathRepresentation_DeleteCameraAt_03(HandleRef pThis, int index);

	/// <summary>
	/// Remove a camera from the path.
	/// </summary>
	public void DeleteCameraAt(int index)
	{
		vtkCameraPathRepresentation_DeleteCameraAt_03(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCameraPathRepresentation_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCameraPathRepresentation_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCameraPathRepresentation_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCameraPathRepresentation_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraPathRepresentation_InitializeHandles_06(HandleRef pThis, HandleRef points);

	/// <summary>
	/// Convenience method to allocate and set the Camera handles from a vtkPoints
	/// instance (corresponding to the camera positions).
	/// If the first and last points are the same, the spline sets
	/// Closed to the on InteractionState and disregards the last point, otherwise Closed
	/// remains unchanged.
	/// </summary>
	public override void InitializeHandles(vtkPoints points)
	{
		vtkCameraPathRepresentation_InitializeHandles_06(GetCppThis(), points?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraPathRepresentation_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCameraPathRepresentation_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCameraPathRepresentation_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCameraPathRepresentation_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraPathRepresentation_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCameraPathRepresentation NewInstance()
	{
		vtkCameraPathRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCameraPathRepresentation_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCameraPathRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCameraPathRepresentation_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCameraPathRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkCameraPathRepresentation vtkCameraPathRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCameraPathRepresentation_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCameraPathRepresentation2 = (vtkCameraPathRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCameraPathRepresentation2.Register(null);
			}
		}
		return vtkCameraPathRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraPathRepresentation_SetDirectional_12(HandleRef pThis, byte val);

	/// <summary>
	/// Sets the representation to be a curve interpolating multiple cameras pointing to their focal
	/// point. If set to false, the cameras are only represented as spheres.
	/// </summary>
	public override void SetDirectional(bool val)
	{
		vtkCameraPathRepresentation_SetDirectional_12(GetCppThis(), (byte)(val ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraPathRepresentation_SetNumberOfHandles_13(HandleRef pThis, int npts);

	/// <summary>
	/// Adjust the number of camera handles while keeping
	///             he same path.
	/// </summary>
	public override void SetNumberOfHandles(int npts)
	{
		vtkCameraPathRepresentation_SetNumberOfHandles_13(GetCppThis(), npts);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCameraPathRepresentation_SetParametricSpline_14(HandleRef pThis, HandleRef spline);

	/// <summary>
	/// Set the parametric spline object.
	/// </summary>
	public override void SetParametricSpline(vtkParametricSpline spline)
	{
		vtkCameraPathRepresentation_SetParametricSpline_14(GetCppThis(), spline?.GetCppThis() ?? default(HandleRef));
	}
}
