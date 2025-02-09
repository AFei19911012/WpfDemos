using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkActor2D
/// </summary>
/// <remarks>
///    a actor that draws 2D data
///
/// vtkActor2D is similar to vtkActor, but it is made to be used with two
/// dimensional images and annotation.  vtkActor2D has a position but does not
/// use a transformation matrix like vtkActor (see the superclass vtkProp
/// for information on positioning vtkActor2D).  vtkActor2D has a reference to
/// a vtkMapper2D object which does the rendering.
///
/// </remarks>
/// <seealso>
///
/// vtkProp  vtkMapper2D vtkProperty2D
/// </seealso>
public class vtkActor2D : vtkProp
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkActor2D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkActor2D()
	{
		MRClassNameKey = "class vtkActor2D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkActor2D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkActor2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkActor2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates an actor2D with the following defaults:
	/// position (0,0) (coordinate system is viewport);
	/// at layer 0.
	/// </summary>
	public new static vtkActor2D New()
	{
		vtkActor2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkActor2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates an actor2D with the following defaults:
	/// position (0,0) (coordinate system is viewport);
	/// at layer 0.
	/// </summary>
	public vtkActor2D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkActor2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkActor2D_GetActors2D_01(HandleRef pThis, HandleRef pc);

	/// <summary>
	/// For some exporters and other other operations we must be
	/// able to collect all the actors or volumes. These methods
	/// are used in that process.
	/// </summary>
	public override void GetActors2D(vtkPropCollection pc)
	{
		vtkActor2D_GetActors2D_01(GetCppThis(), pc?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkActor2D_GetActualPosition2Coordinate_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the actual vtkCoordinate reference that the mapper should use
	/// to position the actor. This is used internally by the mappers and should
	/// be overridden in specialized subclasses and otherwise ignored.
	/// </summary>
	public virtual vtkCoordinate GetActualPosition2Coordinate()
	{
		vtkCoordinate vtkCoordinate2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkActor2D_GetActualPosition2Coordinate_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCoordinate2 = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCoordinate2.Register(null);
			}
		}
		return vtkCoordinate2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkActor2D_GetActualPositionCoordinate_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the actual vtkCoordinate reference that the mapper should use
	/// to position the actor. This is used internally by the mappers and should
	/// be overridden in specialized subclasses and otherwise ignored.
	/// </summary>
	public virtual vtkCoordinate GetActualPositionCoordinate()
	{
		vtkCoordinate vtkCoordinate2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkActor2D_GetActualPositionCoordinate_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCoordinate2 = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCoordinate2.Register(null);
			}
		}
		return vtkCoordinate2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkActor2D_GetHeight_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the height and width of the Actor2D. The value is expressed
	/// as a fraction of the viewport. This really is just another way of
	/// setting the Position2 instance variable.
	/// </summary>
	public double GetHeight()
	{
		return vtkActor2D_GetHeight_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkActor2D_GetLayerNumber_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the layer number in the overlay planes into which to render.
	/// </summary>
	public virtual int GetLayerNumber()
	{
		return vtkActor2D_GetLayerNumber_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkActor2D_GetMTime_06(HandleRef pThis);

	/// <summary>
	/// Return this objects MTime.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkActor2D_GetMTime_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkActor2D_GetMapper_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the vtkMapper2D which defines the data to be drawn.
	/// </summary>
	public virtual vtkMapper2D GetMapper()
	{
		vtkMapper2D vtkMapper2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkActor2D_GetMapper_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMapper2D2 = (vtkMapper2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMapper2D2.Register(null);
			}
		}
		return vtkMapper2D2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkActor2D_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkActor2D_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkActor2D_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkActor2D_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkActor2D_GetPosition_10(HandleRef pThis);

	/// <summary>
	/// Get the PositionCoordinate instance of vtkCoordinate.
	/// This is used for for complicated or relative positioning.
	/// The position variable controls the lower left corner of the Actor2D
	/// </summary>
	public virtual double[] GetPosition()
	{
		IntPtr intPtr = vtkActor2D_GetPosition_10(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkActor2D_GetPosition2_11(HandleRef pThis);

	/// <summary>
	/// Access the Position2 instance variable. This variable controls
	/// the upper right corner of the Actor2D. It is by default
	/// relative to Position and in normalized viewport coordinates.
	/// Some 2D actor subclasses ignore the position2 variable
	/// </summary>
	public virtual double[] GetPosition2()
	{
		IntPtr intPtr = vtkActor2D_GetPosition2_11(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkActor2D_GetPosition2Coordinate_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Access the Position2 instance variable. This variable controls
	/// the upper right corner of the Actor2D. It is by default
	/// relative to Position and in normalized viewport coordinates.
	/// Some 2D actor subclasses ignore the position2 variable
	/// </summary>
	public virtual vtkCoordinate GetPosition2Coordinate()
	{
		vtkCoordinate vtkCoordinate2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkActor2D_GetPosition2Coordinate_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCoordinate2 = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCoordinate2.Register(null);
			}
		}
		return vtkCoordinate2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkActor2D_GetPositionCoordinate_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the PositionCoordinate instance of vtkCoordinate.
	/// This is used for for complicated or relative positioning.
	/// The position variable controls the lower left corner of the Actor2D
	/// </summary>
	public virtual vtkCoordinate GetPositionCoordinate()
	{
		vtkCoordinate vtkCoordinate2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkActor2D_GetPositionCoordinate_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCoordinate2 = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCoordinate2.Register(null);
			}
		}
		return vtkCoordinate2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkActor2D_GetProperty_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns this actor's vtkProperty2D.  Creates a property if one
	/// doesn't already exist.
	/// </summary>
	public vtkProperty2D GetProperty()
	{
		vtkProperty2D vtkProperty2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkActor2D_GetProperty_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkActor2D_GetWidth_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the height and width of the Actor2D. The value is expressed
	/// as a fraction of the viewport. This really is just another way of
	/// setting the Position2 instance variable.
	/// </summary>
	public double GetWidth()
	{
		return vtkActor2D_GetWidth_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkActor2D_HasTranslucentPolygonalGeometry_16(HandleRef pThis);

	/// <summary>
	/// Does this prop have some translucent polygonal geometry?
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkActor2D_HasTranslucentPolygonalGeometry_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkActor2D_IsA_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkActor2D_IsA_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkActor2D_IsTypeOf_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkActor2D_IsTypeOf_18(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkActor2D_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkActor2D NewInstance()
	{
		vtkActor2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkActor2D_NewInstance_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkActor2D_ReleaseGraphicsResources_21(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this actor.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkActor2D_ReleaseGraphicsResources_21(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkActor2D_RenderOpaqueGeometry_22(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Support the standard render methods.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport viewport)
	{
		return vtkActor2D_RenderOpaqueGeometry_22(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkActor2D_RenderOverlay_23(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Support the standard render methods.
	/// </summary>
	public override int RenderOverlay(vtkViewport viewport)
	{
		return vtkActor2D_RenderOverlay_23(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkActor2D_RenderTranslucentPolygonalGeometry_24(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Support the standard render methods.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
	{
		return vtkActor2D_RenderTranslucentPolygonalGeometry_24(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkActor2D_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkActor2D SafeDownCast(vtkObjectBase o)
	{
		vtkActor2D vtkActor2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkActor2D_SafeDownCast_25(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkActor2D2 = (vtkActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkActor2D2.Register(null);
			}
		}
		return vtkActor2D2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkActor2D_SetDisplayPosition_26(HandleRef pThis, int arg0, int arg1);

	/// <summary>
	/// Set the Prop2D's position in display coordinates.
	/// </summary>
	public void SetDisplayPosition(int arg0, int arg1)
	{
		vtkActor2D_SetDisplayPosition_26(GetCppThis(), arg0, arg1);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkActor2D_SetHeight_27(HandleRef pThis, double h);

	/// <summary>
	/// Set/Get the height and width of the Actor2D. The value is expressed
	/// as a fraction of the viewport. This really is just another way of
	/// setting the Position2 instance variable.
	/// </summary>
	public void SetHeight(double h)
	{
		vtkActor2D_SetHeight_27(GetCppThis(), h);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkActor2D_SetLayerNumber_28(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the layer number in the overlay planes into which to render.
	/// </summary>
	public virtual void SetLayerNumber(int _arg)
	{
		vtkActor2D_SetLayerNumber_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkActor2D_SetMapper_29(HandleRef pThis, HandleRef mapper);

	/// <summary>
	/// Set/Get the vtkMapper2D which defines the data to be drawn.
	/// </summary>
	public virtual void SetMapper(vtkMapper2D mapper)
	{
		vtkActor2D_SetMapper_29(GetCppThis(), mapper?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkActor2D_SetPosition_30(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Get the PositionCoordinate instance of vtkCoordinate.
	/// This is used for for complicated or relative positioning.
	/// The position variable controls the lower left corner of the Actor2D
	/// </summary>
	public virtual void SetPosition(IntPtr x)
	{
		vtkActor2D_SetPosition_30(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkActor2D_SetPosition_31(HandleRef pThis, double x, double y);

	/// <summary>
	/// Get the PositionCoordinate instance of vtkCoordinate.
	/// This is used for for complicated or relative positioning.
	/// The position variable controls the lower left corner of the Actor2D
	/// </summary>
	public virtual void SetPosition(double x, double y)
	{
		vtkActor2D_SetPosition_31(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkActor2D_SetPosition2_32(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Access the Position2 instance variable. This variable controls
	/// the upper right corner of the Actor2D. It is by default
	/// relative to Position and in normalized viewport coordinates.
	/// Some 2D actor subclasses ignore the position2 variable
	/// </summary>
	public virtual void SetPosition2(IntPtr x)
	{
		vtkActor2D_SetPosition2_32(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkActor2D_SetPosition2_33(HandleRef pThis, double x, double y);

	/// <summary>
	/// Access the Position2 instance variable. This variable controls
	/// the upper right corner of the Actor2D. It is by default
	/// relative to Position and in normalized viewport coordinates.
	/// Some 2D actor subclasses ignore the position2 variable
	/// </summary>
	public virtual void SetPosition2(double x, double y)
	{
		vtkActor2D_SetPosition2_33(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkActor2D_SetProperty_34(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set this vtkProp's vtkProperty2D.
	/// </summary>
	public virtual void SetProperty(vtkProperty2D arg0)
	{
		vtkActor2D_SetProperty_34(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkActor2D_SetWidth_35(HandleRef pThis, double w);

	/// <summary>
	/// Set/Get the height and width of the Actor2D. The value is expressed
	/// as a fraction of the viewport. This really is just another way of
	/// setting the Position2 instance variable.
	/// </summary>
	public void SetWidth(double w)
	{
		vtkActor2D_SetWidth_35(GetCppThis(), w);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkActor2D_ShallowCopy_36(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Shallow copy of this vtkActor2D. Overloads the virtual vtkProp method.
	/// </summary>
	public override void ShallowCopy(vtkProp prop)
	{
		vtkActor2D_ShallowCopy_36(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}
}
