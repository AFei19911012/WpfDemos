using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkButtonRepresentation
/// </summary>
/// <remarks>
///    abstract class defines the representation for a vtkButtonWidget
///
/// This abstract class is used to specify how the vtkButtonWidget should
/// interact with representations of the vtkButtonWidget. This class may be
/// subclassed so that alternative representations can be created. The class
/// defines an API, and a default implementation, that the vtkButtonWidget
/// interacts with to render itself in the scene.
///
/// The vtkButtonWidget assumes an n-state button so that traversal methods
/// are available for changing, querying and manipulating state. Derived
/// classed determine the actual appearance. The state is represented by an
/// integral value 0&lt;=state&lt;numStates.
///
/// To use this representation, always begin by specifying the number of states.
/// Then follow with the necessary information to represent each state (done through
/// a subclass API).
///
/// </remarks>
/// <seealso>
///
/// vtkButtonWidget
/// </seealso>
public abstract class vtkButtonRepresentation : vtkWidgetRepresentation
{
	/// <summary>
	/// These methods control the appearance of the button as it is being
	/// interacted with. Subclasses will behave differently depending on their
	/// particulars.  HighlightHovering is used when the mouse pointer moves
	/// over the button. HighlightSelecting is set when the button is selected.
	/// Otherwise, the HighlightNormal is used. The Highlight() method will throw
	/// a vtkCommand::HighlightEvent.
	/// </summary>
	public enum HighlightStateType
	{
		/// <summary>enum member</summary>
		HighlightHovering = 1,
		/// <summary>enum member</summary>
		HighlightNormal = 0,
		/// <summary>enum member</summary>
		HighlightSelecting = 2
	}

	/// <summary>
	/// Manipulate the state. Note that the NextState() and PreviousState() methods
	/// use modulo traversal. The "state" integral value will be clamped within
	/// the possible state values (0&lt;=state&lt;NumberOfStates). Note that subclasses
	/// will override these methods in many cases.
	/// </summary>
	public enum InteractionStateType
	{
		/// <summary>enum member</summary>
		Inside = 1,
		/// <summary>enum member</summary>
		Outside = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkButtonRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkButtonRepresentation()
	{
		MRClassNameKey = "class vtkButtonRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkButtonRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkButtonRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern int vtkButtonRepresentation_GetHighlightState_01(HandleRef pThis);

	/// <summary>
	/// These methods control the appearance of the button as it is being
	/// interacted with. Subclasses will behave differently depending on their
	/// particulars.  HighlightHovering is used when the mouse pointer moves
	/// over the button. HighlightSelecting is set when the button is selected.
	/// Otherwise, the HighlightNormal is used. The Highlight() method will throw
	/// a vtkCommand::HighlightEvent.
	/// </summary>
	public virtual int GetHighlightState()
	{
		return vtkButtonRepresentation_GetHighlightState_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkButtonRepresentation_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkButtonRepresentation_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkButtonRepresentation_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkButtonRepresentation_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkButtonRepresentation_GetNumberOfStatesMaxValue_04(HandleRef pThis);

	/// <summary>
	/// Retrieve the current button state.
	/// </summary>
	public virtual int GetNumberOfStatesMaxValue()
	{
		return vtkButtonRepresentation_GetNumberOfStatesMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkButtonRepresentation_GetNumberOfStatesMinValue_05(HandleRef pThis);

	/// <summary>
	/// Retrieve the current button state.
	/// </summary>
	public virtual int GetNumberOfStatesMinValue()
	{
		return vtkButtonRepresentation_GetNumberOfStatesMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkButtonRepresentation_GetState_06(HandleRef pThis);

	/// <summary>
	/// Retrieve the current button state.
	/// </summary>
	public virtual int GetState()
	{
		return vtkButtonRepresentation_GetState_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkButtonRepresentation_Highlight_07(HandleRef pThis, int arg0);

	/// <summary>
	/// These methods control the appearance of the button as it is being
	/// interacted with. Subclasses will behave differently depending on their
	/// particulars.  HighlightHovering is used when the mouse pointer moves
	/// over the button. HighlightSelecting is set when the button is selected.
	/// Otherwise, the HighlightNormal is used. The Highlight() method will throw
	/// a vtkCommand::HighlightEvent.
	/// </summary>
	public override void Highlight(int arg0)
	{
		vtkButtonRepresentation_Highlight_07(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkButtonRepresentation_IsA_08(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkButtonRepresentation_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkButtonRepresentation_IsTypeOf_09(string type);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkButtonRepresentation_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkButtonRepresentation_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new vtkButtonRepresentation NewInstance()
	{
		vtkButtonRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkButtonRepresentation_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkButtonRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkButtonRepresentation_NextState_11(HandleRef pThis);

	/// <summary>
	/// Manipulate the state. Note that the NextState() and PreviousState() methods
	/// use modulo traversal. The "state" integral value will be clamped within
	/// the possible state values (0&lt;=state&lt;NumberOfStates). Note that subclasses
	/// will override these methods in many cases.
	/// </summary>
	public virtual void NextState()
	{
		vtkButtonRepresentation_NextState_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkButtonRepresentation_PreviousState_12(HandleRef pThis);

	/// <summary>
	/// Manipulate the state. Note that the NextState() and PreviousState() methods
	/// use modulo traversal. The "state" integral value will be clamped within
	/// the possible state values (0&lt;=state&lt;NumberOfStates). Note that subclasses
	/// will override these methods in many cases.
	/// </summary>
	public virtual void PreviousState()
	{
		vtkButtonRepresentation_PreviousState_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkButtonRepresentation_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for the class.
	/// </summary>
	public new static vtkButtonRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkButtonRepresentation vtkButtonRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkButtonRepresentation_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkButtonRepresentation2 = (vtkButtonRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkButtonRepresentation2.Register(null);
			}
		}
		return vtkButtonRepresentation2;
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkButtonRepresentation_SetNumberOfStates_14(HandleRef pThis, int _arg);

	/// <summary>
	/// Retrieve the current button state.
	/// </summary>
	public virtual void SetNumberOfStates(int _arg)
	{
		vtkButtonRepresentation_SetNumberOfStates_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkButtonRepresentation_SetState_15(HandleRef pThis, int state);

	/// <summary>
	/// Manipulate the state. Note that the NextState() and PreviousState() methods
	/// use modulo traversal. The "state" integral value will be clamped within
	/// the possible state values (0&lt;=state&lt;NumberOfStates). Note that subclasses
	/// will override these methods in many cases.
	/// </summary>
	public virtual void SetState(int state)
	{
		vtkButtonRepresentation_SetState_15(GetCppThis(), state);
	}

	[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkButtonRepresentation_ShallowCopy_16(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Satisfy some of vtkProp's API.
	/// </summary>
	public override void ShallowCopy(vtkProp prop)
	{
		vtkButtonRepresentation_ShallowCopy_16(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}
}
