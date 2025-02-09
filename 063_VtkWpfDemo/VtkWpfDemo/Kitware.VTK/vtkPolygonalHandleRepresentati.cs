using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPolygonalHandleRepresentation3D
/// </summary>
/// <remarks>
///    represent a user defined handle geometry in 3D space
///
/// This class serves as the geometrical representation of a vtkHandleWidget.
/// The handle can be represented by an arbitrary polygonal data (vtkPolyData),
/// set via SetHandle(vtkPolyData *). The actual position of the handle
/// will be initially assumed to be (0,0,0). You can specify an offset from
/// this position if desired.
/// </remarks>
/// <seealso>
///
/// vtkPointHandleRepresentation3D vtkHandleRepresentation vtkHandleWidget
/// </seealso>
public class vtkPolygonalHandleRepresentation3D : vtkAbstractPolygonalHandleRepresentation3D
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPolygonalHandleRepresentation3D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPolygonalHandleRepresentation3D()
	{
		MRClassNameKey = "class vtkPolygonalHandleRepresentation3D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolygonalHandleRepresentation3D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPolygonalHandleRepresentation3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolygonalHandleRepresentation3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public new static vtkPolygonalHandleRepresentation3D New()
	{
		vtkPolygonalHandleRepresentation3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolygonalHandleRepresentation3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolygonalHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate this class.
	/// </summary>
	public vtkPolygonalHandleRepresentation3D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPolygonalHandleRepresentation3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkPolygonalHandleRepresentation3D_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPolygonalHandleRepresentation3D_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolygonalHandleRepresentation3D_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPolygonalHandleRepresentation3D_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolygonalHandleRepresentation3D_GetOffset_03(HandleRef pThis);

	/// <summary>
	/// Set/get the offset of the handle position with respect to the handle
	/// center, assumed to be the origin.
	/// </summary>
	public virtual double[] GetOffset()
	{
		IntPtr intPtr = vtkPolygonalHandleRepresentation3D_GetOffset_03(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolygonalHandleRepresentation3D_GetOffset_04(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/get the offset of the handle position with respect to the handle
	/// center, assumed to be the origin.
	/// </summary>
	public virtual void GetOffset(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkPolygonalHandleRepresentation3D_GetOffset_04(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolygonalHandleRepresentation3D_GetOffset_05(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the offset of the handle position with respect to the handle
	/// center, assumed to be the origin.
	/// </summary>
	public virtual void GetOffset(IntPtr _arg)
	{
		vtkPolygonalHandleRepresentation3D_GetOffset_05(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolygonalHandleRepresentation3D_IsA_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPolygonalHandleRepresentation3D_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolygonalHandleRepresentation3D_IsTypeOf_07(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPolygonalHandleRepresentation3D_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolygonalHandleRepresentation3D_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new vtkPolygonalHandleRepresentation3D NewInstance()
	{
		vtkPolygonalHandleRepresentation3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolygonalHandleRepresentation3D_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolygonalHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolygonalHandleRepresentation3D_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static vtkPolygonalHandleRepresentation3D SafeDownCast(vtkObjectBase o)
	{
		vtkPolygonalHandleRepresentation3D vtkPolygonalHandleRepresentation3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolygonalHandleRepresentation3D_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolygonalHandleRepresentation3D2 = (vtkPolygonalHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolygonalHandleRepresentation3D2.Register(null);
			}
		}
		return vtkPolygonalHandleRepresentation3D2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolygonalHandleRepresentation3D_SetOffset_11(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/get the offset of the handle position with respect to the handle
	/// center, assumed to be the origin.
	/// </summary>
	public virtual void SetOffset(double _arg1, double _arg2, double _arg3)
	{
		vtkPolygonalHandleRepresentation3D_SetOffset_11(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolygonalHandleRepresentation3D_SetOffset_12(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the offset of the handle position with respect to the handle
	/// center, assumed to be the origin.
	/// </summary>
	public virtual void SetOffset(IntPtr _arg)
	{
		vtkPolygonalHandleRepresentation3D_SetOffset_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolygonalHandleRepresentation3D_SetWorldPosition_13(HandleRef pThis, IntPtr p);

	/// <summary>
	/// Set the position of the point in world and display coordinates.
	/// </summary>
	public override void SetWorldPosition(IntPtr p)
	{
		vtkPolygonalHandleRepresentation3D_SetWorldPosition_13(GetCppThis(), p);
	}
}
