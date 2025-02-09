using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkContourRepresentation
/// </summary>
/// <remarks>
///    represent the vtkContourWidget
///
/// The vtkContourRepresentation is a superclass for various types of
/// representations for vtkContourWidget.
///
/// @par Managing contour points:
/// The classes vtkContourRepresentationNode, vtkContourRepresentationInternals,
/// and vtkContourRepresentationPoint manage the data structure used to represent
/// nodes and points on a contour. A contour may contain several nodes and
/// several additional points. Nodes are usually the result of user-clicked points
/// on the contour. Additional points are created between nodes to generate a
/// smooth curve using some Interpolator -- see the method \c SetLineInterpolator.
///
/// @par Managing contour points:
/// \par
/// The data structure stores both the world and display positions for every
/// point. (This may seem like a duplication.) The default behaviour of this
/// class is to use the WorldPosition to do all the math. Typically a point is
/// added at a given display position. Its corresponding world position is
/// computed using the point placer, and stored. Any query of the display
/// position of a stored point is done via the Renderer, which computes the
/// display position given a world position.
///
/// @par Managing contour points:
/// \par
/// So why maintain the display position? Consider drawing a contour on a
/// volume widget. You might want the contour to be located at a certain world
/// position in the volume or you might want to be overlaid over the window
/// like an Actor2D. The default behaviour of this class is to provide the
/// former behaviour.
///
/// @par Managing contour points:
/// \par
/// To achieve the latter behaviour, override the methods that return the display
/// position (to return the set display position instead of computing it from
/// the world positions) and the method \c BuildLines() to interpolate lines
/// using their display positions instead of world positions.
///
/// </remarks>
/// <seealso>
///
/// vtkContourWidget
/// </seealso>
public abstract class vtkContourRepresentation : vtkWidgetRepresentation
{
	/// <summary>
	/// The tolerance to use when calculations are performed in
	/// world coordinates
	/// </summary>
	public enum Nearby_WrapperEnum
	{
		/// <summary>enum member</summary>
		Nearby = 1,
		/// <summary>enum member</summary>
		Outside = 0
	}

	/// <summary>
	/// The tolerance to use when calculations are performed in
	/// world coordinates
	/// </summary>
	public enum Inactive_WrapperEnum
	{
		/// <summary>enum member</summary>
		Inactive = 0,
		/// <summary>enum member</summary>
		Scale = 3,
		/// <summary>enum member</summary>
		Shift = 2,
		/// <summary>enum member</summary>
		Translate = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkContourRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkContourRepresentation()
	{
		MRClassNameKey = "class vtkContourRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkContourRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkContourRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern int vtkContourRepresentation_ActivateNode_01(HandleRef pThis, IntPtr displayPos);

	/// <summary>
	/// Given a display position, activate a node. The closest
	/// node within tolerance will be activated. If a node is
	/// activated, 1 will be returned, otherwise 0 will be
	/// returned.
	/// </summary>
	public virtual int ActivateNode(IntPtr displayPos)
	{
		return vtkContourRepresentation_ActivateNode_01(GetCppThis(), displayPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_ActivateNode_02(HandleRef pThis, int X, int Y);

	/// <summary>
	/// Given a display position, activate a node. The closest
	/// node within tolerance will be activated. If a node is
	/// activated, 1 will be returned, otherwise 0 will be
	/// returned.
	/// </summary>
	public virtual int ActivateNode(int X, int Y)
	{
		return vtkContourRepresentation_ActivateNode_02(GetCppThis(), X, Y);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_AddIntermediatePointWorldPosition_03(HandleRef pThis, int n, IntPtr point);

	/// <summary>
	/// Add an intermediate point between node n and n+1
	/// (or n and 0 if n is the last node and the loop is closed).
	/// Returns 1 on success or 0 if n is out of range.
	/// </summary>
	public virtual int AddIntermediatePointWorldPosition(int n, IntPtr point)
	{
		return vtkContourRepresentation_AddIntermediatePointWorldPosition_03(GetCppThis(), n, point);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_AddIntermediatePointWorldPosition_04(HandleRef pThis, int n, IntPtr point, long ptId);

	/// <summary>
	/// Add an intermediate point between node n and n+1
	/// (or n and 0 if n is the last node and the loop is closed).
	/// Returns 1 on success or 0 if n is out of range. The added point is
	/// assigned a ptId as supplied.
	/// </summary>
	public virtual int AddIntermediatePointWorldPosition(int n, IntPtr point, long ptId)
	{
		return vtkContourRepresentation_AddIntermediatePointWorldPosition_04(GetCppThis(), n, point, ptId);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_AddNodeAtDisplayPosition_05(HandleRef pThis, IntPtr displayPos);

	/// <summary>
	/// Add a node at a specific display position. This will be
	/// converted into a world position according to the current
	/// constraints of the point placer. Return 0 if a point could
	/// not be added, 1 otherwise.
	/// </summary>
	public virtual int AddNodeAtDisplayPosition(IntPtr displayPos)
	{
		return vtkContourRepresentation_AddNodeAtDisplayPosition_05(GetCppThis(), displayPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_AddNodeAtDisplayPosition_06(HandleRef pThis, int X, int Y);

	/// <summary>
	/// Add a node at a specific display position. This will be
	/// converted into a world position according to the current
	/// constraints of the point placer. Return 0 if a point could
	/// not be added, 1 otherwise.
	/// </summary>
	public virtual int AddNodeAtDisplayPosition(int X, int Y)
	{
		return vtkContourRepresentation_AddNodeAtDisplayPosition_06(GetCppThis(), X, Y);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_AddNodeAtWorldPosition_07(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Add a node at a specific world position. Returns 0 if the
	/// node could not be added, 1 otherwise.
	/// </summary>
	public virtual int AddNodeAtWorldPosition(double x, double y, double z)
	{
		return vtkContourRepresentation_AddNodeAtWorldPosition_07(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_AddNodeAtWorldPosition_08(HandleRef pThis, IntPtr worldPos);

	/// <summary>
	/// Add a node at a specific world position. Returns 0 if the
	/// node could not be added, 1 otherwise.
	/// </summary>
	public virtual int AddNodeAtWorldPosition(IntPtr worldPos)
	{
		return vtkContourRepresentation_AddNodeAtWorldPosition_08(GetCppThis(), worldPos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_AddNodeAtWorldPosition_09(HandleRef pThis, IntPtr worldPos, IntPtr worldOrient);

	/// <summary>
	/// Add a node at a specific world position. Returns 0 if the
	/// node could not be added, 1 otherwise.
	/// </summary>
	public virtual int AddNodeAtWorldPosition(IntPtr worldPos, IntPtr worldOrient)
	{
		return vtkContourRepresentation_AddNodeAtWorldPosition_09(GetCppThis(), worldPos, worldOrient);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_AddNodeOnContour_10(HandleRef pThis, int X, int Y);

	/// <summary>
	/// Given a specific X, Y pixel location, add a new node
	/// on the contour at this location.
	/// </summary>
	public virtual int AddNodeOnContour(int X, int Y)
	{
		return vtkContourRepresentation_AddNodeOnContour_10(GetCppThis(), X, Y);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourRepresentation_BuildRepresentation_11(HandleRef pThis);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void BuildRepresentation()
	{
		vtkContourRepresentation_BuildRepresentation_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourRepresentation_ClearAllNodes_12(HandleRef pThis);

	/// <summary>
	/// Delete all nodes.
	/// </summary>
	public virtual void ClearAllNodes()
	{
		vtkContourRepresentation_ClearAllNodes_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourRepresentation_ClosedLoopOff_13(HandleRef pThis);

	/// <summary>
	/// Set / Get the ClosedLoop value. This ivar indicates whether the contour
	/// forms a closed loop.
	/// </summary>
	public virtual void ClosedLoopOff()
	{
		vtkContourRepresentation_ClosedLoopOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourRepresentation_ClosedLoopOn_14(HandleRef pThis);

	/// <summary>
	/// Set / Get the ClosedLoop value. This ivar indicates whether the contour
	/// forms a closed loop.
	/// </summary>
	public virtual void ClosedLoopOn()
	{
		vtkContourRepresentation_ClosedLoopOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_ComputeInteractionState_15(HandleRef pThis, int X, int Y, int modified);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override int ComputeInteractionState(int X, int Y, int modified)
	{
		return vtkContourRepresentation_ComputeInteractionState_15(GetCppThis(), X, Y, modified);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_DeleteActiveNode_16(HandleRef pThis);

	/// <summary>
	/// Delete the active node. Returns 1 on success or 0 if
	/// the active node did not indicate a valid node.
	/// </summary>
	public virtual int DeleteActiveNode()
	{
		return vtkContourRepresentation_DeleteActiveNode_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_DeleteLastNode_17(HandleRef pThis);

	/// <summary>
	/// Delete the last node. Returns 1 on success or 0 if
	/// there were not any nodes.
	/// </summary>
	public virtual int DeleteLastNode()
	{
		return vtkContourRepresentation_DeleteLastNode_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_DeleteNthNode_18(HandleRef pThis, int n);

	/// <summary>
	/// Delete the nth node. Return 1 on success or 0 if n
	/// is out of range.
	/// </summary>
	public virtual int DeleteNthNode(int n)
	{
		return vtkContourRepresentation_DeleteNthNode_18(GetCppThis(), n);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_GetActiveNodeDisplayPosition_19(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Get the display position of the active node. Will return
	/// 0 if there is no active node, or 1 otherwise.
	/// </summary>
	public virtual int GetActiveNodeDisplayPosition(IntPtr pos)
	{
		return vtkContourRepresentation_GetActiveNodeDisplayPosition_19(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_GetActiveNodeSelected_20(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the active or nth node is selected.
	/// </summary>
	public virtual int GetActiveNodeSelected()
	{
		return vtkContourRepresentation_GetActiveNodeSelected_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_GetActiveNodeWorldOrientation_21(HandleRef pThis, IntPtr orient);

	/// <summary>
	/// Get the world orientation of the active node. Will return
	/// 0 if there is no active node, or 1 otherwise.
	/// </summary>
	public virtual int GetActiveNodeWorldOrientation(IntPtr orient)
	{
		return vtkContourRepresentation_GetActiveNodeWorldOrientation_21(GetCppThis(), orient);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_GetActiveNodeWorldPosition_22(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Get the world position of the active node. Will return
	/// 0 if there is no active node, or 1 otherwise.
	/// </summary>
	public virtual int GetActiveNodeWorldPosition(IntPtr pos)
	{
		return vtkContourRepresentation_GetActiveNodeWorldPosition_22(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_GetClosedLoop_23(HandleRef pThis);

	/// <summary>
	/// Set / Get the ClosedLoop value. This ivar indicates whether the contour
	/// forms a closed loop.
	/// </summary>
	public virtual int GetClosedLoop()
	{
		return vtkContourRepresentation_GetClosedLoop_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourRepresentation_GetContourRepresentationAsPolyData_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the points in this contour as a vtkPolyData.
	/// </summary>
	public virtual vtkPolyData GetContourRepresentationAsPolyData()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContourRepresentation_GetContourRepresentationAsPolyData_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_GetCurrentOperation_25(HandleRef pThis);

	/// <summary>
	/// Set / get the current operation. The widget is either
	/// inactive, or it is being translated.
	/// </summary>
	public virtual int GetCurrentOperation()
	{
		return vtkContourRepresentation_GetCurrentOperation_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_GetCurrentOperationMaxValue_26(HandleRef pThis);

	/// <summary>
	/// Set / get the current operation. The widget is either
	/// inactive, or it is being translated.
	/// </summary>
	public virtual int GetCurrentOperationMaxValue()
	{
		return vtkContourRepresentation_GetCurrentOperationMaxValue_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_GetCurrentOperationMinValue_27(HandleRef pThis);

	/// <summary>
	/// Set / get the current operation. The widget is either
	/// inactive, or it is being translated.
	/// </summary>
	public virtual int GetCurrentOperationMinValue()
	{
		return vtkContourRepresentation_GetCurrentOperationMinValue_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_GetIntermediatePointWorldPosition_28(HandleRef pThis, int n, int idx, IntPtr point);

	/// <summary>
	/// Get the world position of the intermediate point at
	/// index idx between nodes n and (n+1) (or n and 0 if
	/// n is the last node and the loop is closed). Returns
	/// 1 on success or 0 if n or idx are out of range.
	/// </summary>
	public virtual int GetIntermediatePointWorldPosition(int n, int idx, IntPtr point)
	{
		return vtkContourRepresentation_GetIntermediatePointWorldPosition_28(GetCppThis(), n, idx, point);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourRepresentation_GetLineInterpolator_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set / Get the Line Interpolator. The line interpolator
	/// is responsible for generating the line segments connecting
	/// nodes.
	/// </summary>
	public virtual vtkContourLineInterpolator GetLineInterpolator()
	{
		vtkContourLineInterpolator vtkContourLineInterpolator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContourRepresentation_GetLineInterpolator_29(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkContourLineInterpolator2 = (vtkContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkContourLineInterpolator2.Register(null);
			}
		}
		return vtkContourLineInterpolator2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourRepresentation_GetNodePolyData_30(HandleRef pThis, HandleRef poly);

	/// <summary>
	/// Get the nodes and not the intermediate points in this
	/// contour as a vtkPolyData.
	/// </summary>
	public void GetNodePolyData(vtkPolyData poly)
	{
		vtkContourRepresentation_GetNodePolyData_30(GetCppThis(), poly?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_GetNthNodeDisplayPosition_31(HandleRef pThis, int n, IntPtr pos);

	/// <summary>
	/// Get the nth node's display position. Will return
	/// 1 on success, or 0 if there are not at least
	/// (n+1) nodes (0 based counting).
	/// </summary>
	public virtual int GetNthNodeDisplayPosition(int n, IntPtr pos)
	{
		return vtkContourRepresentation_GetNthNodeDisplayPosition_31(GetCppThis(), n, pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_GetNthNodeSelected_32(HandleRef pThis, int arg0);

	/// <summary>
	/// Set/Get whether the active or nth node is selected.
	/// </summary>
	public virtual int GetNthNodeSelected(int arg0)
	{
		return vtkContourRepresentation_GetNthNodeSelected_32(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_GetNthNodeSlope_33(HandleRef pThis, int idx, IntPtr slope);

	/// <summary>
	/// Get the nth node's slope. Will return
	/// 1 on success, or 0 if there are not at least
	/// (n+1) nodes (0 based counting).
	/// </summary>
	public virtual int GetNthNodeSlope(int idx, IntPtr slope)
	{
		return vtkContourRepresentation_GetNthNodeSlope_33(GetCppThis(), idx, slope);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_GetNthNodeWorldOrientation_34(HandleRef pThis, int n, IntPtr orient);

	/// <summary>
	/// Get the nth node's world orientation. Will return
	/// 1 on success, or 0 if there are not at least
	/// (n+1) nodes (0 based counting).
	/// </summary>
	public virtual int GetNthNodeWorldOrientation(int n, IntPtr orient)
	{
		return vtkContourRepresentation_GetNthNodeWorldOrientation_34(GetCppThis(), n, orient);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_GetNthNodeWorldPosition_35(HandleRef pThis, int n, IntPtr pos);

	/// <summary>
	/// Get the nth node's world position. Will return
	/// 1 on success, or 0 if there are not at least
	/// (n+1) nodes (0 based counting).
	/// </summary>
	public virtual int GetNthNodeWorldPosition(int n, IntPtr pos)
	{
		return vtkContourRepresentation_GetNthNodeWorldPosition_35(GetCppThis(), n, pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContourRepresentation_GetNumberOfGenerationsFromBase_36(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkContourRepresentation_GetNumberOfGenerationsFromBase_36(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContourRepresentation_GetNumberOfGenerationsFromBaseType_37(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkContourRepresentation_GetNumberOfGenerationsFromBaseType_37(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_GetNumberOfIntermediatePoints_38(HandleRef pThis, int n);

	/// <summary>
	/// Get the nth node's slope. Will return
	/// 1 on success, or 0 if there are not at least
	/// (n+1) nodes (0 based counting).
	/// </summary>
	public virtual int GetNumberOfIntermediatePoints(int n)
	{
		return vtkContourRepresentation_GetNumberOfIntermediatePoints_38(GetCppThis(), n);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_GetNumberOfNodes_39(HandleRef pThis);

	/// <summary>
	/// Get the number of nodes.
	/// </summary>
	public virtual int GetNumberOfNodes()
	{
		return vtkContourRepresentation_GetNumberOfNodes_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_GetPixelTolerance_40(HandleRef pThis);

	/// <summary>
	/// The tolerance to use when calculations are performed in
	/// display coordinates
	/// </summary>
	public virtual int GetPixelTolerance()
	{
		return vtkContourRepresentation_GetPixelTolerance_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_GetPixelToleranceMaxValue_41(HandleRef pThis);

	/// <summary>
	/// The tolerance to use when calculations are performed in
	/// display coordinates
	/// </summary>
	public virtual int GetPixelToleranceMaxValue()
	{
		return vtkContourRepresentation_GetPixelToleranceMaxValue_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_GetPixelToleranceMinValue_42(HandleRef pThis);

	/// <summary>
	/// The tolerance to use when calculations are performed in
	/// display coordinates
	/// </summary>
	public virtual int GetPixelToleranceMinValue()
	{
		return vtkContourRepresentation_GetPixelToleranceMinValue_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourRepresentation_GetPointPlacer_43(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set / get the current operation. The widget is either
	/// inactive, or it is being translated.
	/// </summary>
	public virtual vtkPointPlacer GetPointPlacer()
	{
		vtkPointPlacer vtkPointPlacer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContourRepresentation_GetPointPlacer_43(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPointPlacer2 = (vtkPointPlacer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPointPlacer2.Register(null);
			}
		}
		return vtkPointPlacer2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_GetShowSelectedNodes_44(HandleRef pThis);

	/// <summary>
	/// A flag to indicate whether to show the Selected nodes
	/// Default is to set it to false.
	/// </summary>
	public virtual int GetShowSelectedNodes()
	{
		return vtkContourRepresentation_GetShowSelectedNodes_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkContourRepresentation_GetWorldTolerance_45(HandleRef pThis);

	/// <summary>
	/// The tolerance to use when calculations are performed in
	/// world coordinates
	/// </summary>
	public virtual double GetWorldTolerance()
	{
		return vtkContourRepresentation_GetWorldTolerance_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkContourRepresentation_GetWorldToleranceMaxValue_46(HandleRef pThis);

	/// <summary>
	/// The tolerance to use when calculations are performed in
	/// world coordinates
	/// </summary>
	public virtual double GetWorldToleranceMaxValue()
	{
		return vtkContourRepresentation_GetWorldToleranceMaxValue_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkContourRepresentation_GetWorldToleranceMinValue_47(HandleRef pThis);

	/// <summary>
	/// The tolerance to use when calculations are performed in
	/// world coordinates
	/// </summary>
	public virtual double GetWorldToleranceMinValue()
	{
		return vtkContourRepresentation_GetWorldToleranceMinValue_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_HasTranslucentPolygonalGeometry_48(HandleRef pThis);

	/// <summary>
	/// Methods required by vtkProp superclass.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkContourRepresentation_HasTranslucentPolygonalGeometry_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_IsA_49(HandleRef pThis, string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkContourRepresentation_IsA_49(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_IsTypeOf_50(string type);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkContourRepresentation_IsTypeOf_50(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourRepresentation_NewInstance_51(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new vtkContourRepresentation NewInstance()
	{
		vtkContourRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContourRepresentation_NewInstance_51(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkContourRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourRepresentation_ReleaseGraphicsResources_52(HandleRef pThis, HandleRef w);

	/// <summary>
	/// Methods required by vtkProp superclass.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow w)
	{
		vtkContourRepresentation_ReleaseGraphicsResources_52(GetCppThis(), w?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_RenderOpaqueGeometry_53(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods required by vtkProp superclass.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport viewport)
	{
		return vtkContourRepresentation_RenderOpaqueGeometry_53(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_RenderOverlay_54(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods required by vtkProp superclass.
	/// </summary>
	public override int RenderOverlay(vtkViewport viewport)
	{
		return vtkContourRepresentation_RenderOverlay_54(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_RenderTranslucentPolygonalGeometry_55(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Methods required by vtkProp superclass.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
	{
		return vtkContourRepresentation_RenderTranslucentPolygonalGeometry_55(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContourRepresentation_SafeDownCast_56(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard VTK methods.
	/// </summary>
	public new static vtkContourRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkContourRepresentation vtkContourRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContourRepresentation_SafeDownCast_56(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkContourRepresentation2 = (vtkContourRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkContourRepresentation2.Register(null);
			}
		}
		return vtkContourRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_SetActiveNodeToDisplayPosition_57(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Move the active node based on a specified display position.
	/// The display position will be converted into a world
	/// position. If the new position is not valid or there is
	/// no active node, a 0 will be returned. Otherwise, on
	/// success a 1 will be returned.
	/// </summary>
	public virtual int SetActiveNodeToDisplayPosition(IntPtr pos)
	{
		return vtkContourRepresentation_SetActiveNodeToDisplayPosition_57(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_SetActiveNodeToDisplayPosition_58(HandleRef pThis, int X, int Y);

	/// <summary>
	/// Move the active node based on a specified display position.
	/// The display position will be converted into a world
	/// position. If the new position is not valid or there is
	/// no active node, a 0 will be returned. Otherwise, on
	/// success a 1 will be returned.
	/// </summary>
	public virtual int SetActiveNodeToDisplayPosition(int X, int Y)
	{
		return vtkContourRepresentation_SetActiveNodeToDisplayPosition_58(GetCppThis(), X, Y);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_SetActiveNodeToWorldPosition_59(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Given a display position, activate a node. The closest
	/// node within tolerance will be activated. If a node is
	/// activated, 1 will be returned, otherwise 0 will be
	/// returned.
	/// </summary>
	public virtual int SetActiveNodeToWorldPosition(IntPtr pos)
	{
		return vtkContourRepresentation_SetActiveNodeToWorldPosition_59(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_SetActiveNodeToWorldPosition_60(HandleRef pThis, IntPtr pos, IntPtr orient);

	/// <summary>
	/// Given a display position, activate a node. The closest
	/// node within tolerance will be activated. If a node is
	/// activated, 1 will be returned, otherwise 0 will be
	/// returned.
	/// </summary>
	public virtual int SetActiveNodeToWorldPosition(IntPtr pos, IntPtr orient)
	{
		return vtkContourRepresentation_SetActiveNodeToWorldPosition_60(GetCppThis(), pos, orient);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourRepresentation_SetClosedLoop_61(HandleRef pThis, int val);

	/// <summary>
	/// Set / Get the ClosedLoop value. This ivar indicates whether the contour
	/// forms a closed loop.
	/// </summary>
	public void SetClosedLoop(int val)
	{
		vtkContourRepresentation_SetClosedLoop_61(GetCppThis(), val);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourRepresentation_SetCurrentOperation_62(HandleRef pThis, int _arg);

	/// <summary>
	/// Set / get the current operation. The widget is either
	/// inactive, or it is being translated.
	/// </summary>
	public virtual void SetCurrentOperation(int _arg)
	{
		vtkContourRepresentation_SetCurrentOperation_62(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourRepresentation_SetCurrentOperationToInactive_63(HandleRef pThis);

	/// <summary>
	/// Set / get the current operation. The widget is either
	/// inactive, or it is being translated.
	/// </summary>
	public void SetCurrentOperationToInactive()
	{
		vtkContourRepresentation_SetCurrentOperationToInactive_63(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourRepresentation_SetCurrentOperationToScale_64(HandleRef pThis);

	/// <summary>
	/// Set / get the current operation. The widget is either
	/// inactive, or it is being translated.
	/// </summary>
	public void SetCurrentOperationToScale()
	{
		vtkContourRepresentation_SetCurrentOperationToScale_64(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourRepresentation_SetCurrentOperationToShift_65(HandleRef pThis);

	/// <summary>
	/// Set / get the current operation. The widget is either
	/// inactive, or it is being translated.
	/// </summary>
	public void SetCurrentOperationToShift()
	{
		vtkContourRepresentation_SetCurrentOperationToShift_65(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourRepresentation_SetCurrentOperationToTranslate_66(HandleRef pThis);

	/// <summary>
	/// Set / get the current operation. The widget is either
	/// inactive, or it is being translated.
	/// </summary>
	public void SetCurrentOperationToTranslate()
	{
		vtkContourRepresentation_SetCurrentOperationToTranslate_66(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourRepresentation_SetLineInterpolator_67(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set / Get the Line Interpolator. The line interpolator
	/// is responsible for generating the line segments connecting
	/// nodes.
	/// </summary>
	public void SetLineInterpolator(vtkContourLineInterpolator arg0)
	{
		vtkContourRepresentation_SetLineInterpolator_67(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_SetNthNodeDisplayPosition_68(HandleRef pThis, int n, int X, int Y);

	/// <summary>
	/// Set the nth node's display position. Display position
	/// will be converted into world position according to the
	/// constraints of the point placer. Will return
	/// 1 on success, or 0 if there are not at least
	/// (n+1) nodes (0 based counting) or the world position
	/// is not valid.
	/// </summary>
	public virtual int SetNthNodeDisplayPosition(int n, int X, int Y)
	{
		return vtkContourRepresentation_SetNthNodeDisplayPosition_68(GetCppThis(), n, X, Y);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_SetNthNodeDisplayPosition_69(HandleRef pThis, int n, IntPtr pos);

	/// <summary>
	/// Set the nth node's display position. Display position
	/// will be converted into world position according to the
	/// constraints of the point placer. Will return
	/// 1 on success, or 0 if there are not at least
	/// (n+1) nodes (0 based counting) or the world position
	/// is not valid.
	/// </summary>
	public virtual int SetNthNodeDisplayPosition(int n, IntPtr pos)
	{
		return vtkContourRepresentation_SetNthNodeDisplayPosition_69(GetCppThis(), n, pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_SetNthNodeSelected_70(HandleRef pThis, int arg0);

	/// <summary>
	/// Set/Get whether the active or nth node is selected.
	/// </summary>
	public virtual int SetNthNodeSelected(int arg0)
	{
		return vtkContourRepresentation_SetNthNodeSelected_70(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_SetNthNodeWorldPosition_71(HandleRef pThis, int n, IntPtr pos);

	/// <summary>
	/// Set the nth node's world position. Will return
	/// 1 on success, or 0 if there are not at least
	/// (n+1) nodes (0 based counting) or the world
	/// position is not valid according to the point
	/// placer.
	/// </summary>
	public virtual int SetNthNodeWorldPosition(int n, IntPtr pos)
	{
		return vtkContourRepresentation_SetNthNodeWorldPosition_71(GetCppThis(), n, pos);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_SetNthNodeWorldPosition_72(HandleRef pThis, int n, IntPtr pos, IntPtr orient);

	/// <summary>
	/// Set the nth node's world position. Will return
	/// 1 on success, or 0 if there are not at least
	/// (n+1) nodes (0 based counting) or the world
	/// position is not valid according to the point
	/// placer.
	/// </summary>
	public virtual int SetNthNodeWorldPosition(int n, IntPtr pos, IntPtr orient)
	{
		return vtkContourRepresentation_SetNthNodeWorldPosition_72(GetCppThis(), n, pos, orient);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourRepresentation_SetPixelTolerance_73(HandleRef pThis, int _arg);

	/// <summary>
	/// The tolerance to use when calculations are performed in
	/// display coordinates
	/// </summary>
	public virtual void SetPixelTolerance(int _arg)
	{
		vtkContourRepresentation_SetPixelTolerance_73(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourRepresentation_SetPointPlacer_74(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set / get the current operation. The widget is either
	/// inactive, or it is being translated.
	/// </summary>
	public void SetPointPlacer(vtkPointPlacer arg0)
	{
		vtkContourRepresentation_SetPointPlacer_74(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourRepresentation_SetRebuildLocator_75(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get the nodes and not the intermediate points in this
	/// contour as a vtkPolyData.
	/// </summary>
	public virtual void SetRebuildLocator(bool _arg)
	{
		vtkContourRepresentation_SetRebuildLocator_75(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourRepresentation_SetShowSelectedNodes_76(HandleRef pThis, int arg0);

	/// <summary>
	/// A flag to indicate whether to show the Selected nodes
	/// Default is to set it to false.
	/// </summary>
	public virtual void SetShowSelectedNodes(int arg0)
	{
		vtkContourRepresentation_SetShowSelectedNodes_76(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourRepresentation_SetWorldTolerance_77(HandleRef pThis, double _arg);

	/// <summary>
	/// The tolerance to use when calculations are performed in
	/// world coordinates
	/// </summary>
	public virtual void SetWorldTolerance(double _arg)
	{
		vtkContourRepresentation_SetWorldTolerance_77(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourRepresentation_ShowSelectedNodesOff_78(HandleRef pThis);

	/// <summary>
	/// A flag to indicate whether to show the Selected nodes
	/// Default is to set it to false.
	/// </summary>
	public virtual void ShowSelectedNodesOff()
	{
		vtkContourRepresentation_ShowSelectedNodesOff_78(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourRepresentation_ShowSelectedNodesOn_79(HandleRef pThis);

	/// <summary>
	/// A flag to indicate whether to show the Selected nodes
	/// Default is to set it to false.
	/// </summary>
	public virtual void ShowSelectedNodesOn()
	{
		vtkContourRepresentation_ShowSelectedNodesOn_79(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourRepresentation_StartWidgetInteraction_80(HandleRef pThis, IntPtr e);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void StartWidgetInteraction(IntPtr e)
	{
		vtkContourRepresentation_StartWidgetInteraction_80(GetCppThis(), e);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContourRepresentation_ToggleActiveNodeSelected_81(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the active or nth node is selected.
	/// </summary>
	public virtual int ToggleActiveNodeSelected()
	{
		return vtkContourRepresentation_ToggleActiveNodeSelected_81(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContourRepresentation_WidgetInteraction_82(HandleRef pThis, IntPtr e);

	/// <summary>
	/// These are methods that satisfy vtkWidgetRepresentation's API.
	/// </summary>
	public override void WidgetInteraction(IntPtr e)
	{
		vtkContourRepresentation_WidgetInteraction_82(GetCppThis(), e);
	}
}
