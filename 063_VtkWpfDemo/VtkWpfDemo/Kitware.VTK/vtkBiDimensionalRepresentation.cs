using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBiDimensionalRepresentation
/// </summary>
/// <remarks>
///    represent the vtkBiDimensionalWidget
///
/// The vtkBiDimensionalRepresentation is used to represent the
/// bi-dimensional measure of an object. This representation
/// consists of two perpendicular lines defined by four
/// vtkHandleRepresentations. The four handles can be independently
/// manipulated consistent with the orthogonal constraint on the lines. (Note:
/// the four points are referred to as Point1, Point2, Point3 and
/// Point4. Point1 and Point2 define the first line; and Point3 and Point4
/// define the second orthogonal line.) This particular class is an abstract
/// class, contrete subclasses (e.g., vtkBiDimensionalRepresentation2D) actual
/// implement the widget.
///
/// To create this widget, you click to place the first two points. The third
/// point is mirrored with the fourth point; when you place the third point
/// (which is orthogonal to the lined defined by the first two points), the
/// fourth point is dropped as well. After definition, the four points can be
/// moved (in constrained fashion, preserving orthogonality). Further, the
/// entire widget can be translated by grabbing the center point of the widget;
/// each line can be moved along the other line; and the entire widget can be
/// rotated around its center point.
///
/// </remarks>
/// <seealso>
///
/// vtkAngleWidget vtkHandleRepresentation vtkBiDimensionalRepresentation2D
/// </seealso>
public abstract class vtkBiDimensionalRepresentation : vtkWidgetRepresentation
{
	/// <summary>
	/// Specify the format to use for labelling the distance. Note that an empty
	/// string results in no label, or a format string without a "%" character
	/// will not print the distance value.
	/// </summary>
	public enum NearP1_WrapperEnum
	{
		/// <summary>enum member</summary>
		NearP1 = 1,
		/// <summary>enum member</summary>
		NearP2 = 2,
		/// <summary>enum member</summary>
		NearP3 = 3,
		/// <summary>enum member</summary>
		NearP4 = 4,
		/// <summary>enum member</summary>
		OnCenter = 9,
		/// <summary>enum member</summary>
		OnL1Inner = 5,
		/// <summary>enum member</summary>
		OnL1Outer = 6,
		/// <summary>enum member</summary>
		OnL2Inner = 7,
		/// <summary>enum member</summary>
		OnL2Outer = 8,
		/// <summary>enum member</summary>
		Outside = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBiDimensionalRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBiDimensionalRepresentation()
	{
		MRClassNameKey = "class vtkBiDimensionalRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBiDimensionalRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBiDimensionalRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern long vtkBiDimensionalRepresentation_GetID_01(HandleRef pThis);

	/// <summary>
	/// Set/get the id to display in the label.
	/// </summary>
	public virtual long GetID()
	{
		return vtkBiDimensionalRepresentation_GetID_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBiDimensionalRepresentation_GetLabelFormat_02(HandleRef pThis);

	/// <summary>
	/// Specify the format to use for labelling the distance. Note that an empty
	/// string results in no label, or a format string without a "%" character
	/// will not print the distance value.
	/// </summary>
	public virtual string GetLabelFormat()
	{
		return Marshal.PtrToStringAnsi(vtkBiDimensionalRepresentation_GetLabelFormat_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBiDimensionalRepresentation_GetLabelPosition_03(HandleRef pThis);

	/// <summary>
	/// Get the position of the widget's label in display coordinates.
	/// </summary>
	public virtual IntPtr GetLabelPosition()
	{
		return vtkBiDimensionalRepresentation_GetLabelPosition_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation_GetLabelPosition_04(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Get the position of the widget's label in display coordinates.
	/// </summary>
	public virtual void GetLabelPosition(IntPtr pos)
	{
		vtkBiDimensionalRepresentation_GetLabelPosition_04(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBiDimensionalRepresentation_GetLabelText_05(HandleRef pThis);

	/// <summary>
	/// Get the text shown in the widget's label.
	/// </summary>
	public virtual string GetLabelText()
	{
		return Marshal.PtrToStringAnsi(vtkBiDimensionalRepresentation_GetLabelText_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkBiDimensionalRepresentation_GetLength1_06(HandleRef pThis);

	/// <summary>
	/// Return the length of the line defined by (Point1,Point2). This is the
	/// distance in the world coordinate system.
	/// </summary>
	public virtual double GetLength1()
	{
		return vtkBiDimensionalRepresentation_GetLength1_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkBiDimensionalRepresentation_GetLength2_07(HandleRef pThis);

	/// <summary>
	/// Return the length of the line defined by (Point3,Point4). This is the
	/// distance in the world coordinate system.
	/// </summary>
	public virtual double GetLength2()
	{
		return vtkBiDimensionalRepresentation_GetLength2_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBiDimensionalRepresentation_GetLine1Visibility_08(HandleRef pThis);

	/// <summary>
	/// Special methods for turning off the lines that define the bi-dimensional
	/// measure. Generally these methods are used by the vtkBiDimensionalWidget to
	/// control the appearance of the widget. Note: turning off Line1 actually turns
	/// off Line1 and Line2.
	/// </summary>
	public virtual int GetLine1Visibility()
	{
		return vtkBiDimensionalRepresentation_GetLine1Visibility_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBiDimensionalRepresentation_GetLine2Visibility_09(HandleRef pThis);

	/// <summary>
	/// Special methods for turning off the lines that define the bi-dimensional
	/// measure. Generally these methods are used by the vtkBiDimensionalWidget to
	/// control the appearance of the widget. Note: turning off Line1 actually turns
	/// off Line1 and Line2.
	/// </summary>
	public virtual int GetLine2Visibility()
	{
		return vtkBiDimensionalRepresentation_GetLine2Visibility_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBiDimensionalRepresentation_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBiDimensionalRepresentation_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBiDimensionalRepresentation_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBiDimensionalRepresentation_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation_GetPoint1DisplayPosition_12(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the four points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual void GetPoint1DisplayPosition(IntPtr pos)
	{
		vtkBiDimensionalRepresentation_GetPoint1DisplayPosition_12(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBiDimensionalRepresentation_GetPoint1Representation_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the handle representations used within the
	/// vtkBiDimensionalRepresentation2D. (Note: properties can be set by
	/// grabbing these representations and setting the properties
	/// appropriately.)
	/// </summary>
	public virtual vtkHandleRepresentation GetPoint1Representation()
	{
		vtkHandleRepresentation vtkHandleRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBiDimensionalRepresentation_GetPoint1Representation_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHandleRepresentation2 = (vtkHandleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHandleRepresentation2.Register(null);
			}
		}
		return vtkHandleRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation_GetPoint1WorldPosition_14(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the four points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual void GetPoint1WorldPosition(IntPtr pos)
	{
		vtkBiDimensionalRepresentation_GetPoint1WorldPosition_14(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation_GetPoint2DisplayPosition_15(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the four points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual void GetPoint2DisplayPosition(IntPtr pos)
	{
		vtkBiDimensionalRepresentation_GetPoint2DisplayPosition_15(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBiDimensionalRepresentation_GetPoint2Representation_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the handle representations used within the
	/// vtkBiDimensionalRepresentation2D. (Note: properties can be set by
	/// grabbing these representations and setting the properties
	/// appropriately.)
	/// </summary>
	public virtual vtkHandleRepresentation GetPoint2Representation()
	{
		vtkHandleRepresentation vtkHandleRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBiDimensionalRepresentation_GetPoint2Representation_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHandleRepresentation2 = (vtkHandleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHandleRepresentation2.Register(null);
			}
		}
		return vtkHandleRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation_GetPoint2WorldPosition_17(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the four points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual void GetPoint2WorldPosition(IntPtr pos)
	{
		vtkBiDimensionalRepresentation_GetPoint2WorldPosition_17(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation_GetPoint3DisplayPosition_18(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the four points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual void GetPoint3DisplayPosition(IntPtr pos)
	{
		vtkBiDimensionalRepresentation_GetPoint3DisplayPosition_18(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBiDimensionalRepresentation_GetPoint3Representation_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the handle representations used within the
	/// vtkBiDimensionalRepresentation2D. (Note: properties can be set by
	/// grabbing these representations and setting the properties
	/// appropriately.)
	/// </summary>
	public virtual vtkHandleRepresentation GetPoint3Representation()
	{
		vtkHandleRepresentation vtkHandleRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBiDimensionalRepresentation_GetPoint3Representation_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHandleRepresentation2 = (vtkHandleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHandleRepresentation2.Register(null);
			}
		}
		return vtkHandleRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation_GetPoint3WorldPosition_20(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the four points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual void GetPoint3WorldPosition(IntPtr pos)
	{
		vtkBiDimensionalRepresentation_GetPoint3WorldPosition_20(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation_GetPoint4DisplayPosition_21(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the four points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual void GetPoint4DisplayPosition(IntPtr pos)
	{
		vtkBiDimensionalRepresentation_GetPoint4DisplayPosition_21(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBiDimensionalRepresentation_GetPoint4Representation_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the handle representations used within the
	/// vtkBiDimensionalRepresentation2D. (Note: properties can be set by
	/// grabbing these representations and setting the properties
	/// appropriately.)
	/// </summary>
	public virtual vtkHandleRepresentation GetPoint4Representation()
	{
		vtkHandleRepresentation vtkHandleRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBiDimensionalRepresentation_GetPoint4Representation_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHandleRepresentation2 = (vtkHandleRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHandleRepresentation2.Register(null);
			}
		}
		return vtkHandleRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation_GetPoint4WorldPosition_23(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the four points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual void GetPoint4WorldPosition(IntPtr pos)
	{
		vtkBiDimensionalRepresentation_GetPoint4WorldPosition_23(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBiDimensionalRepresentation_GetShowLabelAboveWidget_24(HandleRef pThis);

	/// <summary>
	/// Toggle whether to display the label above or below the widget.
	/// Defaults to 1.
	/// </summary>
	public virtual int GetShowLabelAboveWidget()
	{
		return vtkBiDimensionalRepresentation_GetShowLabelAboveWidget_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBiDimensionalRepresentation_GetTolerance_25(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to the representation (in
	/// pixels) in which the cursor is considered near enough to the
	/// representation to be active.
	/// </summary>
	public virtual int GetTolerance()
	{
		return vtkBiDimensionalRepresentation_GetTolerance_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBiDimensionalRepresentation_GetToleranceMaxValue_26(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to the representation (in
	/// pixels) in which the cursor is considered near enough to the
	/// representation to be active.
	/// </summary>
	public virtual int GetToleranceMaxValue()
	{
		return vtkBiDimensionalRepresentation_GetToleranceMaxValue_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBiDimensionalRepresentation_GetToleranceMinValue_27(HandleRef pThis);

	/// <summary>
	/// The tolerance representing the distance to the representation (in
	/// pixels) in which the cursor is considered near enough to the
	/// representation to be active.
	/// </summary>
	public virtual int GetToleranceMinValue()
	{
		return vtkBiDimensionalRepresentation_GetToleranceMinValue_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation_GetWorldLabelPosition_28(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Get the position of the widget's label in display coordinates.
	/// </summary>
	public virtual void GetWorldLabelPosition(IntPtr pos)
	{
		vtkBiDimensionalRepresentation_GetWorldLabelPosition_28(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation_InstantiateHandleRepresentation_29(HandleRef pThis);

	/// <summary>
	/// This method is used to specify the type of handle representation to use
	/// for the four internal vtkHandleRepresentations within
	/// vtkBiDimensionalRepresentation.  To use this method, create a dummy
	/// vtkHandleRepresentation (or subclass), and then invoke this method with
	/// this dummy. Then the vtkBiDimensionalRepresentation uses this dummy to
	/// clone four vtkHandleRepresentations of the same type. Make sure you set the
	/// handle representation before the widget is enabled. (The method
	/// InstantiateHandleRepresentation() is invoked by the vtkBiDimensionalWidget
	/// for the purposes of cloning.)
	/// </summary>
	public virtual void InstantiateHandleRepresentation()
	{
		vtkBiDimensionalRepresentation_InstantiateHandleRepresentation_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBiDimensionalRepresentation_IsA_30(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBiDimensionalRepresentation_IsA_30(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBiDimensionalRepresentation_IsTypeOf_31(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBiDimensionalRepresentation_IsTypeOf_31(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation_Line1VisibilityOff_32(HandleRef pThis);

	/// <summary>
	/// Special methods for turning off the lines that define the bi-dimensional
	/// measure. Generally these methods are used by the vtkBiDimensionalWidget to
	/// control the appearance of the widget. Note: turning off Line1 actually turns
	/// off Line1 and Line2.
	/// </summary>
	public virtual void Line1VisibilityOff()
	{
		vtkBiDimensionalRepresentation_Line1VisibilityOff_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation_Line1VisibilityOn_33(HandleRef pThis);

	/// <summary>
	/// Special methods for turning off the lines that define the bi-dimensional
	/// measure. Generally these methods are used by the vtkBiDimensionalWidget to
	/// control the appearance of the widget. Note: turning off Line1 actually turns
	/// off Line1 and Line2.
	/// </summary>
	public virtual void Line1VisibilityOn()
	{
		vtkBiDimensionalRepresentation_Line1VisibilityOn_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation_Line2VisibilityOff_34(HandleRef pThis);

	/// <summary>
	/// Special methods for turning off the lines that define the bi-dimensional
	/// measure. Generally these methods are used by the vtkBiDimensionalWidget to
	/// control the appearance of the widget. Note: turning off Line1 actually turns
	/// off Line1 and Line2.
	/// </summary>
	public virtual void Line2VisibilityOff()
	{
		vtkBiDimensionalRepresentation_Line2VisibilityOff_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation_Line2VisibilityOn_35(HandleRef pThis);

	/// <summary>
	/// Special methods for turning off the lines that define the bi-dimensional
	/// measure. Generally these methods are used by the vtkBiDimensionalWidget to
	/// control the appearance of the widget. Note: turning off Line1 actually turns
	/// off Line1 and Line2.
	/// </summary>
	public virtual void Line2VisibilityOn()
	{
		vtkBiDimensionalRepresentation_Line2VisibilityOn_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBiDimensionalRepresentation_NewInstance_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new vtkBiDimensionalRepresentation NewInstance()
	{
		vtkBiDimensionalRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBiDimensionalRepresentation_NewInstance_36(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBiDimensionalRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation_Point2WidgetInteraction_37(HandleRef pThis, IntPtr e);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public virtual void Point2WidgetInteraction(IntPtr e)
	{
		vtkBiDimensionalRepresentation_Point2WidgetInteraction_37(GetCppThis(), e);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation_Point3WidgetInteraction_38(HandleRef pThis, IntPtr e);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public virtual void Point3WidgetInteraction(IntPtr e)
	{
		vtkBiDimensionalRepresentation_Point3WidgetInteraction_38(GetCppThis(), e);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBiDimensionalRepresentation_SafeDownCast_39(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static vtkBiDimensionalRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkBiDimensionalRepresentation vtkBiDimensionalRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBiDimensionalRepresentation_SafeDownCast_39(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBiDimensionalRepresentation2 = (vtkBiDimensionalRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBiDimensionalRepresentation2.Register(null);
			}
		}
		return vtkBiDimensionalRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation_SetHandleRepresentation_40(HandleRef pThis, HandleRef handle);

	/// <summary>
	/// This method is used to specify the type of handle representation to use
	/// for the four internal vtkHandleRepresentations within
	/// vtkBiDimensionalRepresentation.  To use this method, create a dummy
	/// vtkHandleRepresentation (or subclass), and then invoke this method with
	/// this dummy. Then the vtkBiDimensionalRepresentation uses this dummy to
	/// clone four vtkHandleRepresentations of the same type. Make sure you set the
	/// handle representation before the widget is enabled. (The method
	/// InstantiateHandleRepresentation() is invoked by the vtkBiDimensionalWidget
	/// for the purposes of cloning.)
	/// </summary>
	public void SetHandleRepresentation(vtkHandleRepresentation handle)
	{
		vtkBiDimensionalRepresentation_SetHandleRepresentation_40(GetCppThis(), handle?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation_SetID_41(HandleRef pThis, long id);

	/// <summary>
	/// Set/get the id to display in the label.
	/// </summary>
	public void SetID(long id)
	{
		vtkBiDimensionalRepresentation_SetID_41(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation_SetLabelFormat_42(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the format to use for labelling the distance. Note that an empty
	/// string results in no label, or a format string without a "%" character
	/// will not print the distance value.
	/// </summary>
	public virtual void SetLabelFormat(string _arg)
	{
		vtkBiDimensionalRepresentation_SetLabelFormat_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation_SetLine1Visibility_43(HandleRef pThis, int _arg);

	/// <summary>
	/// Special methods for turning off the lines that define the bi-dimensional
	/// measure. Generally these methods are used by the vtkBiDimensionalWidget to
	/// control the appearance of the widget. Note: turning off Line1 actually turns
	/// off Line1 and Line2.
	/// </summary>
	public virtual void SetLine1Visibility(int _arg)
	{
		vtkBiDimensionalRepresentation_SetLine1Visibility_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation_SetLine2Visibility_44(HandleRef pThis, int _arg);

	/// <summary>
	/// Special methods for turning off the lines that define the bi-dimensional
	/// measure. Generally these methods are used by the vtkBiDimensionalWidget to
	/// control the appearance of the widget. Note: turning off Line1 actually turns
	/// off Line1 and Line2.
	/// </summary>
	public virtual void SetLine2Visibility(int _arg)
	{
		vtkBiDimensionalRepresentation_SetLine2Visibility_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation_SetPoint1DisplayPosition_45(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the four points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual void SetPoint1DisplayPosition(IntPtr pos)
	{
		vtkBiDimensionalRepresentation_SetPoint1DisplayPosition_45(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation_SetPoint1WorldPosition_46(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the four points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual void SetPoint1WorldPosition(IntPtr pos)
	{
		vtkBiDimensionalRepresentation_SetPoint1WorldPosition_46(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation_SetPoint2DisplayPosition_47(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the four points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual void SetPoint2DisplayPosition(IntPtr pos)
	{
		vtkBiDimensionalRepresentation_SetPoint2DisplayPosition_47(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation_SetPoint2WorldPosition_48(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the four points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual void SetPoint2WorldPosition(IntPtr pos)
	{
		vtkBiDimensionalRepresentation_SetPoint2WorldPosition_48(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation_SetPoint3DisplayPosition_49(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the four points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual void SetPoint3DisplayPosition(IntPtr pos)
	{
		vtkBiDimensionalRepresentation_SetPoint3DisplayPosition_49(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation_SetPoint3WorldPosition_50(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the four points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual void SetPoint3WorldPosition(IntPtr pos)
	{
		vtkBiDimensionalRepresentation_SetPoint3WorldPosition_50(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation_SetPoint4DisplayPosition_51(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the four points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual void SetPoint4DisplayPosition(IntPtr pos)
	{
		vtkBiDimensionalRepresentation_SetPoint4DisplayPosition_51(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation_SetPoint4WorldPosition_52(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the four points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public virtual void SetPoint4WorldPosition(IntPtr pos)
	{
		vtkBiDimensionalRepresentation_SetPoint4WorldPosition_52(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation_SetShowLabelAboveWidget_53(HandleRef pThis, int _arg);

	/// <summary>
	/// Toggle whether to display the label above or below the widget.
	/// Defaults to 1.
	/// </summary>
	public virtual void SetShowLabelAboveWidget(int _arg)
	{
		vtkBiDimensionalRepresentation_SetShowLabelAboveWidget_53(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation_SetTolerance_54(HandleRef pThis, int _arg);

	/// <summary>
	/// The tolerance representing the distance to the representation (in
	/// pixels) in which the cursor is considered near enough to the
	/// representation to be active.
	/// </summary>
	public virtual void SetTolerance(int _arg)
	{
		vtkBiDimensionalRepresentation_SetTolerance_54(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation_ShowLabelAboveWidgetOff_55(HandleRef pThis);

	/// <summary>
	/// Toggle whether to display the label above or below the widget.
	/// Defaults to 1.
	/// </summary>
	public virtual void ShowLabelAboveWidgetOff()
	{
		vtkBiDimensionalRepresentation_ShowLabelAboveWidgetOff_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation_ShowLabelAboveWidgetOn_56(HandleRef pThis);

	/// <summary>
	/// Toggle whether to display the label above or below the widget.
	/// Defaults to 1.
	/// </summary>
	public virtual void ShowLabelAboveWidgetOn()
	{
		vtkBiDimensionalRepresentation_ShowLabelAboveWidgetOn_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation_StartWidgetDefinition_57(HandleRef pThis, IntPtr e);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public virtual void StartWidgetDefinition(IntPtr e)
	{
		vtkBiDimensionalRepresentation_StartWidgetDefinition_57(GetCppThis(), e);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation_StartWidgetManipulation_58(HandleRef pThis, IntPtr e);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public virtual void StartWidgetManipulation(IntPtr e)
	{
		vtkBiDimensionalRepresentation_StartWidgetManipulation_58(GetCppThis(), e);
	}
}
/// <summary>
///    vtkBiDimensionalRepresentation2D
/// </summary>
/// <remarks>
///    represent the vtkBiDimensionalWidget
///
/// The vtkBiDimensionalRepresentation2D is used to represent the
/// bi-dimensional measure in a 2D (overlay) context. This representation
/// consists of two perpendicular lines defined by four
/// vtkHandleRepresentations. The four handles can be independently
/// manipulated consistent with the orthogonal constraint on the lines. (Note:
/// the four points are referred to as Point1, Point2, Point3 and
/// Point4. Point1 and Point2 define the first line; and Point3 and Point4
/// define the second orthogonal line.)
///
/// To create this widget, you click to place the first two points. The third
/// point is mirrored with the fourth point; when you place the third point
/// (which is orthogonal to the lined defined by the first two points), the
/// fourth point is dropped as well. After definition, the four points can be
/// moved (in constrained fashion, preserving orthogonality). Further, the
/// entire widget can be translated by grabbing the center point of the widget;
/// each line can be moved along the other line; and the entire widget can be
/// rotated around its center point.
///
/// </remarks>
/// <seealso>
///
/// vtkAngleWidget vtkHandleRepresentation vtkBiDimensionalRepresentation
/// </seealso>
public class vtkBiDimensionalRepresentation2D : vtkBiDimensionalRepresentation
{
	/// <summary>
	/// Retrieve the property used to control the appearance of the text
	/// labels.
	/// </summary>
	public new enum NearP1_WrapperEnum
	{
		/// <summary>enum member</summary>
		NearP1 = 1,
		/// <summary>enum member</summary>
		NearP2 = 2,
		/// <summary>enum member</summary>
		NearP3 = 3,
		/// <summary>enum member</summary>
		NearP4 = 4,
		/// <summary>enum member</summary>
		OnCenter = 9,
		/// <summary>enum member</summary>
		OnL1Inner = 5,
		/// <summary>enum member</summary>
		OnL1Outer = 6,
		/// <summary>enum member</summary>
		OnL2Inner = 7,
		/// <summary>enum member</summary>
		OnL2Outer = 8,
		/// <summary>enum member</summary>
		Outside = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBiDimensionalRepresentation2D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBiDimensionalRepresentation2D()
	{
		MRClassNameKey = "class vtkBiDimensionalRepresentation2D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBiDimensionalRepresentation2D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBiDimensionalRepresentation2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBiDimensionalRepresentation2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public new static vtkBiDimensionalRepresentation2D New()
	{
		vtkBiDimensionalRepresentation2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBiDimensionalRepresentation2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBiDimensionalRepresentation2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public vtkBiDimensionalRepresentation2D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBiDimensionalRepresentation2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkBiDimensionalRepresentation2D_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkBiDimensionalRepresentation2D_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBiDimensionalRepresentation2D_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override int ComputeInteractionState(int X, int Y, int modify)
	{
		return vtkBiDimensionalRepresentation2D_ComputeInteractionState_02(GetCppThis(), X, Y, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBiDimensionalRepresentation2D_GetLabelPosition_03(HandleRef pThis);

	/// <summary>
	/// Get the position of the widget's label in display coordinates.
	/// </summary>
	public override IntPtr GetLabelPosition()
	{
		return vtkBiDimensionalRepresentation2D_GetLabelPosition_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation2D_GetLabelPosition_04(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Get the position of the widget's label in display coordinates.
	/// </summary>
	public override void GetLabelPosition(IntPtr pos)
	{
		vtkBiDimensionalRepresentation2D_GetLabelPosition_04(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBiDimensionalRepresentation2D_GetLabelText_05(HandleRef pThis);

	/// <summary>
	/// Get the text shown in the widget's label.
	/// </summary>
	public override string GetLabelText()
	{
		return Marshal.PtrToStringAnsi(vtkBiDimensionalRepresentation2D_GetLabelText_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBiDimensionalRepresentation2D_GetLineProperty_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve the property used to control the appearance of the two
	/// orthogonal lines.
	/// </summary>
	public virtual vtkProperty2D GetLineProperty()
	{
		vtkProperty2D vtkProperty2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBiDimensionalRepresentation2D_GetLineProperty_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2D2 = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2D2.Register(null);
			}
		}
		return vtkProperty2D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBiDimensionalRepresentation2D_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBiDimensionalRepresentation2D_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBiDimensionalRepresentation2D_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBiDimensionalRepresentation2D_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBiDimensionalRepresentation2D_GetSelectedLineProperty_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve the property used to control the appearance of the two
	/// orthogonal lines.
	/// </summary>
	public virtual vtkProperty2D GetSelectedLineProperty()
	{
		vtkProperty2D vtkProperty2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBiDimensionalRepresentation2D_GetSelectedLineProperty_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2D2 = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2D2.Register(null);
			}
		}
		return vtkProperty2D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBiDimensionalRepresentation2D_GetTextProperty_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieve the property used to control the appearance of the text
	/// labels.
	/// </summary>
	public virtual vtkTextProperty GetTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBiDimensionalRepresentation2D_GetTextProperty_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTextProperty2 = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTextProperty2.Register(null);
			}
		}
		return vtkTextProperty2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation2D_GetWorldLabelPosition_11(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Get the position of the widget's label in display coordinates.
	/// </summary>
	public override void GetWorldLabelPosition(IntPtr pos)
	{
		vtkBiDimensionalRepresentation2D_GetWorldLabelPosition_11(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation2D_Highlight_12(HandleRef pThis, int highlightOn);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void Highlight(int highlightOn)
	{
		vtkBiDimensionalRepresentation2D_Highlight_12(GetCppThis(), highlightOn);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBiDimensionalRepresentation2D_IsA_13(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBiDimensionalRepresentation2D_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBiDimensionalRepresentation2D_IsTypeOf_14(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBiDimensionalRepresentation2D_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBiDimensionalRepresentation2D_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new vtkBiDimensionalRepresentation2D NewInstance()
	{
		vtkBiDimensionalRepresentation2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBiDimensionalRepresentation2D_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBiDimensionalRepresentation2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation2D_Point2WidgetInteraction_17(HandleRef pThis, IntPtr e);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void Point2WidgetInteraction(IntPtr e)
	{
		vtkBiDimensionalRepresentation2D_Point2WidgetInteraction_17(GetCppThis(), e);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation2D_Point3WidgetInteraction_18(HandleRef pThis, IntPtr e);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void Point3WidgetInteraction(IntPtr e)
	{
		vtkBiDimensionalRepresentation2D_Point3WidgetInteraction_18(GetCppThis(), e);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation2D_ReleaseGraphicsResources_19(HandleRef pThis, HandleRef w);

	/// <summary>
	/// Methods required by vtkProp superclass.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow w)
	{
		vtkBiDimensionalRepresentation2D_ReleaseGraphicsResources_19(GetCppThis(), w?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBiDimensionalRepresentation2D_RenderOverlay_20(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods required by vtkProp superclass.
	/// </summary>
	public override int RenderOverlay(vtkViewport viewport)
	{
		return vtkBiDimensionalRepresentation2D_RenderOverlay_20(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBiDimensionalRepresentation2D_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static vtkBiDimensionalRepresentation2D SafeDownCast(vtkObjectBase o)
	{
		vtkBiDimensionalRepresentation2D vtkBiDimensionalRepresentation2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBiDimensionalRepresentation2D_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBiDimensionalRepresentation2D2 = (vtkBiDimensionalRepresentation2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBiDimensionalRepresentation2D2.Register(null);
			}
		}
		return vtkBiDimensionalRepresentation2D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation2D_StartWidgetDefinition_22(HandleRef pThis, IntPtr e);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void StartWidgetDefinition(IntPtr e)
	{
		vtkBiDimensionalRepresentation2D_StartWidgetDefinition_22(GetCppThis(), e);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation2D_StartWidgetManipulation_23(HandleRef pThis, IntPtr e);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void StartWidgetManipulation(IntPtr e)
	{
		vtkBiDimensionalRepresentation2D_StartWidgetManipulation_23(GetCppThis(), e);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBiDimensionalRepresentation2D_WidgetInteraction_24(HandleRef pThis, IntPtr e);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void WidgetInteraction(IntPtr e)
	{
		vtkBiDimensionalRepresentation2D_WidgetInteraction_24(GetCppThis(), e);
	}
}
