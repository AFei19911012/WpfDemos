using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDistanceRepresentation3D
/// </summary>
/// <remarks>
///    represent the vtkDistanceWidget
///
/// The vtkDistanceRepresentation3D is a representation for the
/// vtkDistanceWidget. This representation consists of a measuring line (axis)
/// and two vtkHandleWidgets to place the end points of the line. Note that
/// this particular widget draws its representation in 3D space, so the widget
/// can be occluded.
///
/// </remarks>
/// <seealso>
///
/// vtkDistanceWidget vtkDistanceRepresentation vtkDistanceRepresentation2D
/// </seealso>
public class vtkDistanceRepresentation3D : vtkDistanceRepresentation
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDistanceRepresentation3D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDistanceRepresentation3D()
	{
		MRClassNameKey = "class vtkDistanceRepresentation3D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDistanceRepresentation3D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDistanceRepresentation3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistanceRepresentation3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate class.
	/// </summary>
	public new static vtkDistanceRepresentation3D New()
	{
		vtkDistanceRepresentation3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistanceRepresentation3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDistanceRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate class.
	/// </summary>
	public vtkDistanceRepresentation3D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDistanceRepresentation3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDistanceRepresentation3D_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// Method to satisfy superclasses' API.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkDistanceRepresentation3D_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistanceRepresentation3D_GetBounds_02(HandleRef pThis);

	/// <summary>
	/// Method to satisfy superclasses' API.
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkDistanceRepresentation3D_GetBounds_02(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDistanceRepresentation3D_GetDistance_03(HandleRef pThis);

	/// <summary>
	/// Satisfy the superclasses API.
	/// </summary>
	public override double GetDistance()
	{
		return vtkDistanceRepresentation3D_GetDistance_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistanceRepresentation3D_GetGlyphActor_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Convenience method to get the glyph actor. Using this it is
	/// possible to control the appearance of the glyphs.
	/// </summary>
	public virtual vtkActor GetGlyphActor()
	{
		vtkActor vtkActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistanceRepresentation3D_GetGlyphActor_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkActor2 = (vtkActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkActor2.Register(null);
			}
		}
		return vtkActor2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDistanceRepresentation3D_GetGlyphScale_05(HandleRef pThis);

	/// <summary>
	/// Scale the glyphs used as tick marks. By default it is
	/// 1/40th of the length.
	/// </summary>
	public virtual double GetGlyphScale()
	{
		return vtkDistanceRepresentation3D_GetGlyphScale_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistanceRepresentation3D_GetLabelActor_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Convenience method Get the label actor. It is possible to
	/// control the appearance of the label.
	/// </summary>
	public virtual vtkFollower GetLabelActor()
	{
		vtkFollower vtkFollower2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistanceRepresentation3D_GetLabelActor_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFollower2 = (vtkFollower)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFollower2.Register(null);
			}
		}
		return vtkFollower2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDistanceRepresentation3D_GetLabelPosition_07(HandleRef pThis);

	/// <summary>
	/// Set/Get position of the label title in normalized coordinates [0,1].
	/// 0 is at the start of the line whereas 1 is at the end.
	/// </summary>
	public virtual double GetLabelPosition()
	{
		return vtkDistanceRepresentation3D_GetLabelPosition_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistanceRepresentation3D_GetLabelProperty_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the distance annotation property
	/// </summary>
	public virtual vtkProperty GetLabelProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistanceRepresentation3D_GetLabelProperty_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2 = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2.Register(null);
			}
		}
		return vtkProperty2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistanceRepresentation3D_GetLabelScale_09(HandleRef pThis);

	/// <summary>
	/// Scale text (font size along each dimension). This helps control
	/// the appearance of the 3D text.
	/// </summary>
	public virtual IntPtr GetLabelScale()
	{
		return vtkDistanceRepresentation3D_GetLabelScale_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistanceRepresentation3D_GetLineProperty_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Convenience method to get the line actor property.
	/// </summary>
	public virtual vtkProperty GetLineProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistanceRepresentation3D_GetLineProperty_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2 = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2.Register(null);
			}
		}
		return vtkProperty2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistanceRepresentation3D_GetMaximumNumberOfRulerTicks_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum number of ticks in ruler mode.
	/// </summary>
	public virtual int GetMaximumNumberOfRulerTicks()
	{
		return vtkDistanceRepresentation3D_GetMaximumNumberOfRulerTicks_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistanceRepresentation3D_GetMaximumNumberOfRulerTicksMaxValue_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum number of ticks in ruler mode.
	/// </summary>
	public virtual int GetMaximumNumberOfRulerTicksMaxValue()
	{
		return vtkDistanceRepresentation3D_GetMaximumNumberOfRulerTicksMaxValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistanceRepresentation3D_GetMaximumNumberOfRulerTicksMinValue_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum number of ticks in ruler mode.
	/// </summary>
	public virtual int GetMaximumNumberOfRulerTicksMinValue()
	{
		return vtkDistanceRepresentation3D_GetMaximumNumberOfRulerTicksMinValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDistanceRepresentation3D_GetNumberOfGenerationsFromBase_14(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDistanceRepresentation3D_GetNumberOfGenerationsFromBase_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDistanceRepresentation3D_GetNumberOfGenerationsFromBaseType_15(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDistanceRepresentation3D_GetNumberOfGenerationsFromBaseType_15(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation3D_GetPoint1DisplayPosition_16(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override void GetPoint1DisplayPosition(IntPtr pos)
	{
		vtkDistanceRepresentation3D_GetPoint1DisplayPosition_16(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistanceRepresentation3D_GetPoint1WorldPosition_17(HandleRef pThis);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override double[] GetPoint1WorldPosition()
	{
		IntPtr intPtr = vtkDistanceRepresentation3D_GetPoint1WorldPosition_17(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation3D_GetPoint1WorldPosition_18(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override void GetPoint1WorldPosition(IntPtr pos)
	{
		vtkDistanceRepresentation3D_GetPoint1WorldPosition_18(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation3D_GetPoint2DisplayPosition_19(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override void GetPoint2DisplayPosition(IntPtr pos)
	{
		vtkDistanceRepresentation3D_GetPoint2DisplayPosition_19(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistanceRepresentation3D_GetPoint2WorldPosition_20(HandleRef pThis);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override double[] GetPoint2WorldPosition()
	{
		IntPtr intPtr = vtkDistanceRepresentation3D_GetPoint2WorldPosition_20(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation3D_GetPoint2WorldPosition_21(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override void GetPoint2WorldPosition(IntPtr pos)
	{
		vtkDistanceRepresentation3D_GetPoint2WorldPosition_21(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistanceRepresentation3D_IsA_22(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDistanceRepresentation3D_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistanceRepresentation3D_IsTypeOf_23(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDistanceRepresentation3D_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistanceRepresentation3D_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new vtkDistanceRepresentation3D NewInstance()
	{
		vtkDistanceRepresentation3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistanceRepresentation3D_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDistanceRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation3D_ReleaseGraphicsResources_26(HandleRef pThis, HandleRef w);

	/// <summary>
	/// Methods required by vtkProp superclass.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow w)
	{
		vtkDistanceRepresentation3D_ReleaseGraphicsResources_26(GetCppThis(), w?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistanceRepresentation3D_RenderOpaqueGeometry_27(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods required by vtkProp superclass.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport viewport)
	{
		return vtkDistanceRepresentation3D_RenderOpaqueGeometry_27(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistanceRepresentation3D_RenderTranslucentPolygonalGeometry_28(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods required by vtkProp superclass.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
	{
		return vtkDistanceRepresentation3D_RenderTranslucentPolygonalGeometry_28(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistanceRepresentation3D_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static vtkDistanceRepresentation3D SafeDownCast(vtkObjectBase o)
	{
		vtkDistanceRepresentation3D vtkDistanceRepresentation3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistanceRepresentation3D_SafeDownCast_29(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDistanceRepresentation3D2 = (vtkDistanceRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDistanceRepresentation3D2.Register(null);
			}
		}
		return vtkDistanceRepresentation3D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation3D_SetGlyphScale_30(HandleRef pThis, double scale);

	/// <summary>
	/// Scale the glyphs used as tick marks. By default it is
	/// 1/40th of the length.
	/// </summary>
	public void SetGlyphScale(double scale)
	{
		vtkDistanceRepresentation3D_SetGlyphScale_30(GetCppThis(), scale);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation3D_SetLabelActor_31(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Convenience method Get the label actor. It is possible to
	/// control the appearance of the label.
	/// </summary>
	public virtual void SetLabelActor(vtkFollower arg0)
	{
		vtkDistanceRepresentation3D_SetLabelActor_31(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation3D_SetLabelPosition_32(HandleRef pThis, double labelPosition);

	/// <summary>
	/// Set/Get position of the label title in normalized coordinates [0,1].
	/// 0 is at the start of the line whereas 1 is at the end.
	/// </summary>
	public void SetLabelPosition(double labelPosition)
	{
		vtkDistanceRepresentation3D_SetLabelPosition_32(GetCppThis(), labelPosition);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation3D_SetLabelScale_33(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Scale text (font size along each dimension). This helps control
	/// the appearance of the 3D text.
	/// </summary>
	public void SetLabelScale(double x, double y, double z)
	{
		vtkDistanceRepresentation3D_SetLabelScale_33(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation3D_SetLabelScale_34(HandleRef pThis, IntPtr scale);

	/// <summary>
	/// Scale text (font size along each dimension). This helps control
	/// the appearance of the 3D text.
	/// </summary>
	public virtual void SetLabelScale(IntPtr scale)
	{
		vtkDistanceRepresentation3D_SetLabelScale_34(GetCppThis(), scale);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation3D_SetMaximumNumberOfRulerTicks_35(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the maximum number of ticks in ruler mode.
	/// </summary>
	public virtual void SetMaximumNumberOfRulerTicks(int _arg)
	{
		vtkDistanceRepresentation3D_SetMaximumNumberOfRulerTicks_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation3D_SetPoint1DisplayPosition_36(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override void SetPoint1DisplayPosition(IntPtr pos)
	{
		vtkDistanceRepresentation3D_SetPoint1DisplayPosition_36(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation3D_SetPoint1WorldPosition_37(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override void SetPoint1WorldPosition(IntPtr pos)
	{
		vtkDistanceRepresentation3D_SetPoint1WorldPosition_37(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation3D_SetPoint2DisplayPosition_38(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override void SetPoint2DisplayPosition(IntPtr pos)
	{
		vtkDistanceRepresentation3D_SetPoint2DisplayPosition_38(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistanceRepresentation3D_SetPoint2WorldPosition_39(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Methods to Set/Get the coordinates of the two points defining
	/// this representation. Note that methods are available for both
	/// display and world coordinates.
	/// </summary>
	public override void SetPoint2WorldPosition(IntPtr pos)
	{
		vtkDistanceRepresentation3D_SetPoint2WorldPosition_39(GetCppThis(), pos);
	}
}
