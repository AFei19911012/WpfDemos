using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkFinitePlaneRepresentation
/// </summary>
/// <remarks>
///    represent the vtkFinitePlaneWidget.
///
/// This class is a concrete representation for the vtkFinitePlaneWidget. It
/// represents a plane with three handles: one on two faces, plus a
/// center handle. Through interaction with the widget, the plane
/// representation can be arbitrarily positioned and modified in the 3D space.
///
/// To use this representation, you normally use the PlaceWidget() method
/// to position the widget at a specified region in space.
///
/// </remarks>
/// <seealso>
///
/// vtkFinitePlaneWidget vtkImplicitPlaneWidget2
/// </seealso>
public class vtkFinitePlaneRepresentation : vtkWidgetRepresentation
{
	/// <summary>
	/// Get the properties on the normal (line and cone).
	/// </summary>
	public enum InteractionStateType
	{
		/// <summary>enum member</summary>
		ModifyV1 = 2,
		/// <summary>enum member</summary>
		ModifyV2 = 3,
		/// <summary>enum member</summary>
		MoveOrigin = 1,
		/// <summary>enum member</summary>
		Moving = 4,
		/// <summary>enum member</summary>
		Outside = 0,
		/// <summary>enum member</summary>
		Pushing = 6,
		/// <summary>enum member</summary>
		Rotating = 5
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFinitePlaneRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFinitePlaneRepresentation()
	{
		MRClassNameKey = "class vtkFinitePlaneRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFinitePlaneRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFinitePlaneRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFinitePlaneRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public new static vtkFinitePlaneRepresentation New()
	{
		vtkFinitePlaneRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFinitePlaneRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFinitePlaneRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the class.
	/// </summary>
	public vtkFinitePlaneRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkFinitePlaneRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkFinitePlaneRepresentation_BuildRepresentation_01(HandleRef pThis);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkFinitePlaneRepresentation_BuildRepresentation_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFinitePlaneRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override int ComputeInteractionState(int X, int Y, int modify)
	{
		return vtkFinitePlaneRepresentation_ComputeInteractionState_02(GetCppThis(), X, Y, modify);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneRepresentation_DrawPlaneOff_03(HandleRef pThis);

	/// <summary>
	/// Enable/disable the drawing of the plane. In some cases the plane
	/// interferes with the object that it is operating on (i.e., the
	/// plane interferes with the cut surface it produces producing
	/// z-buffer artifacts.)
	/// </summary>
	public virtual void DrawPlaneOff()
	{
		vtkFinitePlaneRepresentation_DrawPlaneOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneRepresentation_DrawPlaneOn_04(HandleRef pThis);

	/// <summary>
	/// Enable/disable the drawing of the plane. In some cases the plane
	/// interferes with the object that it is operating on (i.e., the
	/// plane interferes with the cut surface it produces producing
	/// z-buffer artifacts.)
	/// </summary>
	public virtual void DrawPlaneOn()
	{
		vtkFinitePlaneRepresentation_DrawPlaneOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFinitePlaneRepresentation_GetBounds_05(HandleRef pThis);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkFinitePlaneRepresentation_GetBounds_05(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkFinitePlaneRepresentation_GetDrawPlane_06(HandleRef pThis);

	/// <summary>
	/// Enable/disable the drawing of the plane. In some cases the plane
	/// interferes with the object that it is operating on (i.e., the
	/// plane interferes with the cut surface it produces producing
	/// z-buffer artifacts.)
	/// </summary>
	public virtual bool GetDrawPlane()
	{
		return (vtkFinitePlaneRepresentation_GetDrawPlane_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFinitePlaneRepresentation_GetInteractionStateMaxValue_07(HandleRef pThis);

	/// <summary>
	/// Methods supporting, and required by, the rendering process.
	/// </summary>
	public virtual int GetInteractionStateMaxValue()
	{
		return vtkFinitePlaneRepresentation_GetInteractionStateMaxValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFinitePlaneRepresentation_GetInteractionStateMinValue_08(HandleRef pThis);

	/// <summary>
	/// Methods supporting, and required by, the rendering process.
	/// </summary>
	public virtual int GetInteractionStateMinValue()
	{
		return vtkFinitePlaneRepresentation_GetInteractionStateMinValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFinitePlaneRepresentation_GetNormal_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the normal to the plane.
	/// </summary>
	public virtual double[] GetNormal()
	{
		IntPtr intPtr = vtkFinitePlaneRepresentation_GetNormal_09(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneRepresentation_GetNormal_10(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the normal to the plane.
	/// </summary>
	public virtual void GetNormal(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkFinitePlaneRepresentation_GetNormal_10(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneRepresentation_GetNormal_11(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the normal to the plane.
	/// </summary>
	public virtual void GetNormal(IntPtr _arg)
	{
		vtkFinitePlaneRepresentation_GetNormal_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFinitePlaneRepresentation_GetNormalProperty_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties on the normal (line and cone).
	/// </summary>
	public virtual vtkProperty GetNormalProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFinitePlaneRepresentation_GetNormalProperty_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkFinitePlaneRepresentation_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFinitePlaneRepresentation_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFinitePlaneRepresentation_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFinitePlaneRepresentation_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFinitePlaneRepresentation_GetOrigin_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the origin of the plane.
	/// </summary>
	public virtual double[] GetOrigin()
	{
		IntPtr intPtr = vtkFinitePlaneRepresentation_GetOrigin_15(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneRepresentation_GetOrigin_16(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the origin of the plane.
	/// </summary>
	public virtual void GetOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkFinitePlaneRepresentation_GetOrigin_16(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneRepresentation_GetOrigin_17(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the origin of the plane.
	/// </summary>
	public virtual void GetOrigin(IntPtr _arg)
	{
		vtkFinitePlaneRepresentation_GetOrigin_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFinitePlaneRepresentation_GetPlaneProperty_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the plane properties. The
	/// properties of the plane when selected and normal can be
	/// set.
	/// </summary>
	public virtual vtkProperty GetPlaneProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFinitePlaneRepresentation_GetPlaneProperty_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkFinitePlaneRepresentation_GetPolyData_19(HandleRef pThis, HandleRef pd);

	/// <summary>
	/// Grab the polydata that defines the plane. The polydata contains a single
	/// polygon.
	/// </summary>
	public void GetPolyData(vtkPolyData pd)
	{
		vtkFinitePlaneRepresentation_GetPolyData_19(GetCppThis(), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFinitePlaneRepresentation_GetRepresentationState_20(HandleRef pThis);

	/// <summary>
	/// Sets the visual appearance of the representation based on the
	/// state it is in. This state is usually the same as InteractionState.
	/// </summary>
	public virtual int GetRepresentationState()
	{
		return vtkFinitePlaneRepresentation_GetRepresentationState_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFinitePlaneRepresentation_GetSelectedHandleProperty_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the handle properties (the little balls are the handles). The
	/// properties of the handles, when selected or normal, can be
	/// specified.
	/// </summary>
	public virtual vtkProperty GetSelectedHandleProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFinitePlaneRepresentation_GetSelectedHandleProperty_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkFinitePlaneRepresentation_GetSelectedNormalProperty_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the properties on the normal (line and cone).
	/// </summary>
	public virtual vtkProperty GetSelectedNormalProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFinitePlaneRepresentation_GetSelectedNormalProperty_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkFinitePlaneRepresentation_GetSelectedPlaneProperty_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the plane properties. The
	/// properties of the plane when selected and normal can be
	/// set.
	/// </summary>
	public virtual vtkProperty GetSelectedPlaneProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFinitePlaneRepresentation_GetSelectedPlaneProperty_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkFinitePlaneRepresentation_GetTubing_24(HandleRef pThis);

	/// <summary>
	/// Turn on/off tubing of the wire outline of the plane. The tube thickens
	/// the line by wrapping with a vtkTubeFilter.
	/// </summary>
	public virtual bool GetTubing()
	{
		return (vtkFinitePlaneRepresentation_GetTubing_24(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFinitePlaneRepresentation_GetV1_25(HandleRef pThis);

	/// <summary>
	/// Set/Get the v1 vector of the plane.
	/// </summary>
	public virtual double[] GetV1()
	{
		IntPtr intPtr = vtkFinitePlaneRepresentation_GetV1_25(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneRepresentation_GetV1_26(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Set/Get the v1 vector of the plane.
	/// </summary>
	public virtual void GetV1(ref double _arg1, ref double _arg2)
	{
		vtkFinitePlaneRepresentation_GetV1_26(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneRepresentation_GetV1_27(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the v1 vector of the plane.
	/// </summary>
	public virtual void GetV1(IntPtr _arg)
	{
		vtkFinitePlaneRepresentation_GetV1_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFinitePlaneRepresentation_GetV1HandleProperty_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the handle properties (the little balls are the handles). The
	/// properties of the handles, when selected or normal, can be
	/// specified.
	/// </summary>
	public virtual vtkProperty GetV1HandleProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFinitePlaneRepresentation_GetV1HandleProperty_28(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkFinitePlaneRepresentation_GetV2_29(HandleRef pThis);

	/// <summary>
	/// Set/Get the v2 vector of the plane.
	/// </summary>
	public virtual double[] GetV2()
	{
		IntPtr intPtr = vtkFinitePlaneRepresentation_GetV2_29(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneRepresentation_GetV2_30(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// Set/Get the v2 vector of the plane.
	/// </summary>
	public virtual void GetV2(ref double _arg1, ref double _arg2)
	{
		vtkFinitePlaneRepresentation_GetV2_30(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneRepresentation_GetV2_31(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the v2 vector of the plane.
	/// </summary>
	public virtual void GetV2(IntPtr _arg)
	{
		vtkFinitePlaneRepresentation_GetV2_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFinitePlaneRepresentation_GetV2HandleProperty_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the handle properties (the little balls are the handles). The
	/// properties of the handles, when selected or normal, can be
	/// specified.
	/// </summary>
	public virtual vtkProperty GetV2HandleProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFinitePlaneRepresentation_GetV2HandleProperty_32(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkFinitePlaneRepresentation_HandlesOff_33(HandleRef pThis);

	/// <summary>
	/// Switches handles (the spheres) on or off by manipulating the underlying
	/// actor visibility.
	/// </summary>
	public virtual void HandlesOff()
	{
		vtkFinitePlaneRepresentation_HandlesOff_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneRepresentation_HandlesOn_34(HandleRef pThis);

	/// <summary>
	/// Switches handles (the spheres) on or off by manipulating the underlying
	/// actor visibility.
	/// </summary>
	public virtual void HandlesOn()
	{
		vtkFinitePlaneRepresentation_HandlesOn_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFinitePlaneRepresentation_HasTranslucentPolygonalGeometry_35(HandleRef pThis);

	/// <summary>
	/// Methods supporting, and required by, the rendering process.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkFinitePlaneRepresentation_HasTranslucentPolygonalGeometry_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFinitePlaneRepresentation_IsA_36(HandleRef pThis, string type);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFinitePlaneRepresentation_IsA_36(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFinitePlaneRepresentation_IsTypeOf_37(string type);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFinitePlaneRepresentation_IsTypeOf_37(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneRepresentation_MovePoint1_38(HandleRef pThis, IntPtr p1, IntPtr p2);

	/// <summary>
	/// Get the properties on the normal (line and cone).
	/// </summary>
	public void MovePoint1(IntPtr p1, IntPtr p2)
	{
		vtkFinitePlaneRepresentation_MovePoint1_38(GetCppThis(), p1, p2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneRepresentation_MovePoint2_39(HandleRef pThis, IntPtr p1, IntPtr p2);

	/// <summary>
	/// Get the properties on the normal (line and cone).
	/// </summary>
	public void MovePoint2(IntPtr p1, IntPtr p2)
	{
		vtkFinitePlaneRepresentation_MovePoint2_39(GetCppThis(), p1, p2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFinitePlaneRepresentation_NewInstance_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public new vtkFinitePlaneRepresentation NewInstance()
	{
		vtkFinitePlaneRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFinitePlaneRepresentation_NewInstance_41(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFinitePlaneRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneRepresentation_PlaceWidget_42(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void PlaceWidget(IntPtr bounds)
	{
		vtkFinitePlaneRepresentation_PlaceWidget_42(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneRepresentation_Push_43(HandleRef pThis, IntPtr p1, IntPtr p2);

	/// <summary>
	/// Get the properties on the normal (line and cone).
	/// </summary>
	public void Push(IntPtr p1, IntPtr p2)
	{
		vtkFinitePlaneRepresentation_Push_43(GetCppThis(), p1, p2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneRepresentation_RegisterPickers_44(HandleRef pThis);

	/// <summary>
	/// Get the properties on the normal (line and cone).
	/// </summary>
	public override void RegisterPickers()
	{
		vtkFinitePlaneRepresentation_RegisterPickers_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneRepresentation_ReleaseGraphicsResources_45(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting, and required by, the rendering process.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkFinitePlaneRepresentation_ReleaseGraphicsResources_45(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFinitePlaneRepresentation_RenderOpaqueGeometry_46(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting, and required by, the rendering process.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport arg0)
	{
		return vtkFinitePlaneRepresentation_RenderOpaqueGeometry_46(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFinitePlaneRepresentation_RenderTranslucentPolygonalGeometry_47(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Methods supporting, and required by, the rendering process.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkFinitePlaneRepresentation_RenderTranslucentPolygonalGeometry_47(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneRepresentation_Rotate_48(HandleRef pThis, int X, int Y, IntPtr p1, IntPtr p2, IntPtr vpn);

	/// <summary>
	/// Get the properties on the normal (line and cone).
	/// </summary>
	public void Rotate(int X, int Y, IntPtr p1, IntPtr p2, IntPtr vpn)
	{
		vtkFinitePlaneRepresentation_Rotate_48(GetCppThis(), X, Y, p1, p2, vpn);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFinitePlaneRepresentation_SafeDownCast_49(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard vtkObject methods
	/// </summary>
	public new static vtkFinitePlaneRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkFinitePlaneRepresentation vtkFinitePlaneRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFinitePlaneRepresentation_SafeDownCast_49(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFinitePlaneRepresentation2 = (vtkFinitePlaneRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFinitePlaneRepresentation2.Register(null);
			}
		}
		return vtkFinitePlaneRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneRepresentation_SetDrawPlane_50(HandleRef pThis, byte plane);

	/// <summary>
	/// Enable/disable the drawing of the plane. In some cases the plane
	/// interferes with the object that it is operating on (i.e., the
	/// plane interferes with the cut surface it produces producing
	/// z-buffer artifacts.)
	/// </summary>
	public void SetDrawPlane(bool plane)
	{
		vtkFinitePlaneRepresentation_SetDrawPlane_50(GetCppThis(), (byte)(plane ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneRepresentation_SetHandles_51(HandleRef pThis, byte handles);

	/// <summary>
	/// Switches handles (the spheres) on or off by manipulating the underlying
	/// actor visibility.
	/// </summary>
	public void SetHandles(bool handles)
	{
		vtkFinitePlaneRepresentation_SetHandles_51(GetCppThis(), (byte)(handles ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneRepresentation_SetInteractionState_52(HandleRef pThis, int _arg);

	/// <summary>
	/// Methods supporting, and required by, the rendering process.
	/// </summary>
	public virtual void SetInteractionState(int _arg)
	{
		vtkFinitePlaneRepresentation_SetInteractionState_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneRepresentation_SetNormal_53(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set/Get the normal to the plane.
	/// </summary>
	public void SetNormal(double x, double y, double z)
	{
		vtkFinitePlaneRepresentation_SetNormal_53(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneRepresentation_SetNormal_54(HandleRef pThis, IntPtr n);

	/// <summary>
	/// Set/Get the normal to the plane.
	/// </summary>
	public void SetNormal(IntPtr n)
	{
		vtkFinitePlaneRepresentation_SetNormal_54(GetCppThis(), n);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneRepresentation_SetOrigin_55(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set/Get the origin of the plane.
	/// </summary>
	public void SetOrigin(double x, double y, double z)
	{
		vtkFinitePlaneRepresentation_SetOrigin_55(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneRepresentation_SetOrigin_56(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Set/Get the origin of the plane.
	/// </summary>
	public void SetOrigin(IntPtr x)
	{
		vtkFinitePlaneRepresentation_SetOrigin_56(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneRepresentation_SetRepresentationState_57(HandleRef pThis, int arg0);

	/// <summary>
	/// Sets the visual appearance of the representation based on the
	/// state it is in. This state is usually the same as InteractionState.
	/// </summary>
	public virtual void SetRepresentationState(int arg0)
	{
		vtkFinitePlaneRepresentation_SetRepresentationState_57(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneRepresentation_SetTubing_58(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off tubing of the wire outline of the plane. The tube thickens
	/// the line by wrapping with a vtkTubeFilter.
	/// </summary>
	public virtual void SetTubing(bool _arg)
	{
		vtkFinitePlaneRepresentation_SetTubing_58(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneRepresentation_SetV1_59(HandleRef pThis, double x, double y);

	/// <summary>
	/// Set/Get the v1 vector of the plane.
	/// </summary>
	public void SetV1(double x, double y)
	{
		vtkFinitePlaneRepresentation_SetV1_59(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneRepresentation_SetV1_60(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Set/Get the v1 vector of the plane.
	/// </summary>
	public void SetV1(IntPtr x)
	{
		vtkFinitePlaneRepresentation_SetV1_60(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneRepresentation_SetV2_61(HandleRef pThis, double x, double y);

	/// <summary>
	/// Set/Get the v2 vector of the plane.
	/// </summary>
	public void SetV2(double x, double y)
	{
		vtkFinitePlaneRepresentation_SetV2_61(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneRepresentation_SetV2_62(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Set/Get the v2 vector of the plane.
	/// </summary>
	public void SetV2(IntPtr x)
	{
		vtkFinitePlaneRepresentation_SetV2_62(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneRepresentation_StartWidgetInteraction_63(HandleRef pThis, IntPtr e);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void StartWidgetInteraction(IntPtr e)
	{
		vtkFinitePlaneRepresentation_StartWidgetInteraction_63(GetCppThis(), e);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneRepresentation_TranslateOrigin_64(HandleRef pThis, IntPtr p1, IntPtr p2);

	/// <summary>
	/// Get the properties on the normal (line and cone).
	/// </summary>
	public void TranslateOrigin(IntPtr p1, IntPtr p2)
	{
		vtkFinitePlaneRepresentation_TranslateOrigin_64(GetCppThis(), p1, p2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneRepresentation_TubingOff_65(HandleRef pThis);

	/// <summary>
	/// Turn on/off tubing of the wire outline of the plane. The tube thickens
	/// the line by wrapping with a vtkTubeFilter.
	/// </summary>
	public virtual void TubingOff()
	{
		vtkFinitePlaneRepresentation_TubingOff_65(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneRepresentation_TubingOn_66(HandleRef pThis);

	/// <summary>
	/// Turn on/off tubing of the wire outline of the plane. The tube thickens
	/// the line by wrapping with a vtkTubeFilter.
	/// </summary>
	public virtual void TubingOn()
	{
		vtkFinitePlaneRepresentation_TubingOn_66(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFinitePlaneRepresentation_WidgetInteraction_67(HandleRef pThis, IntPtr e);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void WidgetInteraction(IntPtr e)
	{
		vtkFinitePlaneRepresentation_WidgetInteraction_67(GetCppThis(), e);
	}
}
