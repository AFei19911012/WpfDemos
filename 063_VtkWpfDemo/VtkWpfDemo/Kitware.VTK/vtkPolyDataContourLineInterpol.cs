using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPolyDataContourLineInterpolator
/// </summary>
/// <remarks>
///    Contour interpolator for polygonal data
///
///
/// vtkPolyDataContourLineInterpolator is an abstract base class for contour
/// line interpolators that interpolate on polygonal data.
///
/// </remarks>
public abstract class vtkPolyDataContourLineInterpolator : vtkContourLineInterpolator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataContourLineInterpolator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPolyDataContourLineInterpolator()
	{
		MRClassNameKey = "class vtkPolyDataContourLineInterpolator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataContourLineInterpolator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPolyDataContourLineInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern long vtkPolyDataContourLineInterpolator_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPolyDataContourLineInterpolator_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyDataContourLineInterpolator_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPolyDataContourLineInterpolator_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataContourLineInterpolator_GetPolys_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Be sure to add polydata on which you wish to place points to this list
	/// or they will not be considered for placement.
	/// </summary>
	public virtual vtkPolyDataCollection GetPolys()
	{
		vtkPolyDataCollection vtkPolyDataCollection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataContourLineInterpolator_GetPolys_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyDataCollection2 = (vtkPolyDataCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyDataCollection2.Register(null);
			}
		}
		return vtkPolyDataCollection2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataContourLineInterpolator_InterpolateLine_04(HandleRef pThis, HandleRef ren, HandleRef rep, int idx1, int idx2);

	/// <summary>
	/// Subclasses that wish to interpolate a line segment must implement this.
	/// For instance vtkBezierContourLineInterpolator adds nodes between idx1
	/// and idx2, that allow the contour to adhere to a bezier curve.
	/// </summary>
	public override int InterpolateLine(vtkRenderer ren, vtkContourRepresentation rep, int idx1, int idx2)
	{
		return vtkPolyDataContourLineInterpolator_InterpolateLine_04(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), rep?.GetCppThis() ?? default(HandleRef), idx1, idx2);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataContourLineInterpolator_IsA_05(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPolyDataContourLineInterpolator_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataContourLineInterpolator_IsTypeOf_06(string type);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPolyDataContourLineInterpolator_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataContourLineInterpolator_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new vtkPolyDataContourLineInterpolator NewInstance()
	{
		vtkPolyDataContourLineInterpolator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataContourLineInterpolator_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolyDataContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataContourLineInterpolator_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instances of this class.
	/// </summary>
	public new static vtkPolyDataContourLineInterpolator SafeDownCast(vtkObjectBase o)
	{
		vtkPolyDataContourLineInterpolator vtkPolyDataContourLineInterpolator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataContourLineInterpolator_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyDataContourLineInterpolator2 = (vtkPolyDataContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyDataContourLineInterpolator2.Register(null);
			}
		}
		return vtkPolyDataContourLineInterpolator2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataContourLineInterpolator_UpdateNode_09(HandleRef pThis, HandleRef arg0, HandleRef arg1, IntPtr arg2, int arg3);

	/// <summary>
	/// The interpolator is given a chance to update the node.
	/// vtkImageContourLineInterpolator updates the idx'th node in the contour,
	/// so it automatically sticks to edges in the vicinity as the user
	/// constructs the contour.
	/// Returns 0 if the node (world position) is unchanged.
	/// </summary>
	public override int UpdateNode(vtkRenderer arg0, vtkContourRepresentation arg1, IntPtr arg2, int arg3)
	{
		return vtkPolyDataContourLineInterpolator_UpdateNode_09(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef), arg2, arg3);
	}
}
