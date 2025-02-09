using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPolyDataSourceWidget
/// </summary>
/// <remarks>
///    abstract PolyDataSource-based 3D widget
///
/// This abstract class serves as parent to 3D widgets that have simple
/// vtkPolyDataSource instances defining their geometry.
///
/// In addition to what is offered by the vtk3DWidget parent, this class
/// makes it possible to manipulate the underlying polydatasource and to
/// PlaceWidget() according to that, instead of having to make use of
/// SetInput() or SetProp3D().
///
/// Implementors of child classes HAVE to implement their PlaceWidget(bounds)
/// to check for the existence of Input and Prop3D FIRST.  If these don't
/// exist, place according to the underlying PolyDataSource.  Child classes
/// also have to imprement UpdatePlacement(), which updates the widget according
/// to the geometry of the underlying PolyDataSource.
///
/// </remarks>
/// <seealso>
///
/// vtk3DWidget vtkLineWidget vtkPlaneWidget vtkSphereWidget
/// </seealso>
public abstract class vtkPolyDataSourceWidget : vtk3DWidget
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataSourceWidget";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPolyDataSourceWidget()
	{
		MRClassNameKey = "class vtkPolyDataSourceWidget";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataSourceWidget"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPolyDataSourceWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern long vtkPolyDataSourceWidget_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPolyDataSourceWidget_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyDataSourceWidget_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPolyDataSourceWidget_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataSourceWidget_GetPolyDataAlgorithm_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns underlying vtkPolyDataAlgorithm that determines geometry.  This
	/// can be modified after which PlaceWidget() or UpdatePlacement() can be
	/// called.  UpdatePlacement() will always update the planewidget according
	/// to the geometry of the underlying PolyDataAlgorithm.  PlaceWidget() will
	/// only make use of this geometry if there is no Input and no Prop3D set.
	/// </summary>
	public virtual vtkPolyDataAlgorithm GetPolyDataAlgorithm()
	{
		vtkPolyDataAlgorithm vtkPolyDataAlgorithm2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataSourceWidget_GetPolyDataAlgorithm_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyDataAlgorithm2 = (vtkPolyDataAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyDataAlgorithm2.Register(null);
			}
		}
		return vtkPolyDataAlgorithm2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataSourceWidget_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPolyDataSourceWidget_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataSourceWidget_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPolyDataSourceWidget_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataSourceWidget_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPolyDataSourceWidget NewInstance()
	{
		vtkPolyDataSourceWidget result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataSourceWidget_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolyDataSourceWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataSourceWidget_PlaceWidget_07(HandleRef pThis);

	/// <summary>
	/// Overrides vtk3DWidget PlaceWidget() so that it doesn't complain if
	/// there's no Input and no Prop3D.
	/// </summary>
	public override void PlaceWidget()
	{
		vtkPolyDataSourceWidget_PlaceWidget_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataSourceWidget_PlaceWidget_08(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// We have to redeclare this abstract, PlaceWidget() requires it.  You HAVE
	/// to override this in your concrete child classes.  If there's no Prop3D
	/// and no Input, your PlaceWidget must make use of the underlying
	/// PolyDataSource to do its work.
	/// </summary>
	public override void PlaceWidget(IntPtr bounds)
	{
		vtkPolyDataSourceWidget_PlaceWidget_08(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataSourceWidget_PlaceWidget_09(HandleRef pThis, double xmin, double xmax, double ymin, double ymax, double zmin, double zmax);

	/// <summary>
	/// Convenience method brought over from vtkPlaneWidget.
	/// </summary>
	public override void PlaceWidget(double xmin, double xmax, double ymin, double ymax, double zmin, double zmax)
	{
		vtkPolyDataSourceWidget_PlaceWidget_09(GetCppThis(), xmin, xmax, ymin, ymax, zmin, zmax);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataSourceWidget_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPolyDataSourceWidget SafeDownCast(vtkObjectBase o)
	{
		vtkPolyDataSourceWidget vtkPolyDataSourceWidget2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataSourceWidget_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyDataSourceWidget2 = (vtkPolyDataSourceWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyDataSourceWidget2.Register(null);
			}
		}
		return vtkPolyDataSourceWidget2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataSourceWidget_UpdatePlacement_11(HandleRef pThis);

	/// <summary>
	/// If you've made changes to the underlying vtkPolyDataSource AFTER your
	/// initial call to PlaceWidget(), use this method to realise the changes
	/// in the widget.
	/// </summary>
	public virtual void UpdatePlacement()
	{
		vtkPolyDataSourceWidget_UpdatePlacement_11(GetCppThis());
	}
}
