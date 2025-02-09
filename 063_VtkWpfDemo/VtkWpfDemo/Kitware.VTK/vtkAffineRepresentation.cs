using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAffineRepresentation
/// </summary>
/// <remarks>
///    abstract class for representing affine transformation widgets
///
/// This class defines an API for affine transformation widget
/// representations. These representations interact with vtkAffineWidget. The
/// basic functionality of the affine representation is to maintain a
/// transformation matrix.
///
/// This class may be subclassed so that alternative representations can
/// be created.  The class defines an API and a default implementation that
/// the vtkAffineWidget interacts with to render itself in the scene.
///
/// @warning
/// The separation of the widget event handling and representation enables
/// users and developers to create new appearances for the widget. It also
/// facilitates parallel processing, where the client application handles
/// events, and remote representations of the widget are slaves to the
/// client (and do not handle events).
///
/// </remarks>
/// <seealso>
///
/// vtkAffineWidget vtkWidgetRepresentation vtkAbstractWidget
/// </seealso>
public abstract class vtkAffineRepresentation : vtkWidgetRepresentation
{
	/// <summary>
	/// The tolerance representing the distance to the widget (in pixels)
	/// in which the cursor is considered near enough to the widget to
	/// be active.
	/// </summary>
	public enum InteractionStateType
	{
		/// <summary>enum member</summary>
		MoveOrigin = 19,
		/// <summary>enum member</summary>
		MoveOriginX = 17,
		/// <summary>enum member</summary>
		MoveOriginY = 18,
		/// <summary>enum member</summary>
		Outside = 0,
		/// <summary>enum member</summary>
		Rotate = 1,
		/// <summary>enum member</summary>
		ScaleEEdge = 6,
		/// <summary>enum member</summary>
		ScaleNE = 9,
		/// <summary>enum member</summary>
		ScaleNEdge = 7,
		/// <summary>enum member</summary>
		ScaleNW = 11,
		/// <summary>enum member</summary>
		ScaleSE = 12,
		/// <summary>enum member</summary>
		ScaleSEdge = 8,
		/// <summary>enum member</summary>
		ScaleSW = 10,
		/// <summary>enum member</summary>
		ScaleWEdge = 5,
		/// <summary>enum member</summary>
		ShearEEdge = 13,
		/// <summary>enum member</summary>
		ShearNEdge = 15,
		/// <summary>enum member</summary>
		ShearSEdge = 16,
		/// <summary>enum member</summary>
		ShearWEdge = 14,
		/// <summary>enum member</summary>
		Translate = 2,
		/// <summary>enum member</summary>
		TranslateX = 3,
		/// <summary>enum member</summary>
		TranslateY = 4
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAffineRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAffineRepresentation()
	{
		MRClassNameKey = "class vtkAffineRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAffineRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAffineRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern long vtkAffineRepresentation_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAffineRepresentation_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAffineRepresentation_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAffineRepresentation_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAffineRepresentation_GetTolerance_03(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to the widget (in pixels)
	/// in which the cursor is considered near enough to the widget to
	/// be active.
	/// </summary>
	public virtual int GetTolerance()
	{
		return vtkAffineRepresentation_GetTolerance_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAffineRepresentation_GetToleranceMaxValue_04(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to the widget (in pixels)
	/// in which the cursor is considered near enough to the widget to
	/// be active.
	/// </summary>
	public virtual int GetToleranceMaxValue()
	{
		return vtkAffineRepresentation_GetToleranceMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAffineRepresentation_GetToleranceMinValue_05(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to the widget (in pixels)
	/// in which the cursor is considered near enough to the widget to
	/// be active.
	/// </summary>
	public virtual int GetToleranceMinValue()
	{
		return vtkAffineRepresentation_GetToleranceMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAffineRepresentation_GetTransform_06(HandleRef pThis, HandleRef t);

	/// <summary>
	/// Retrieve a linear transform characterizing the affine transformation
	/// generated by this widget. This method copies its internal transform into
	/// the transform provided. The transform is relative to the initial placement
	/// of the representation (i.e., when PlaceWidget() is invoked).
	/// </summary>
	public virtual void GetTransform(vtkTransform t)
	{
		vtkAffineRepresentation_GetTransform_06(GetCppThis(), t?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAffineRepresentation_IsA_07(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAffineRepresentation_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAffineRepresentation_IsTypeOf_08(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAffineRepresentation_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAffineRepresentation_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new vtkAffineRepresentation NewInstance()
	{
		vtkAffineRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAffineRepresentation_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAffineRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAffineRepresentation_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static vtkAffineRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkAffineRepresentation vtkAffineRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAffineRepresentation_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAffineRepresentation2 = (vtkAffineRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAffineRepresentation2.Register(null);
			}
		}
		return vtkAffineRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAffineRepresentation_SetTolerance_11(HandleRef pThis, int _arg);

	/// <summary>
	/// The tolerance representing the distance to the widget (in pixels)
	/// in which the cursor is considered near enough to the widget to
	/// be active.
	/// </summary>
	public virtual void SetTolerance(int _arg)
	{
		vtkAffineRepresentation_SetTolerance_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAffineRepresentation_ShallowCopy_12(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Methods to make this class properly act like a vtkWidgetRepresentation.
	/// </summary>
	public override void ShallowCopy(vtkProp prop)
	{
		vtkAffineRepresentation_ShallowCopy_12(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}
}
