using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkView
/// </summary>
/// <remarks>
///    The superclass for all views.
///
///
/// vtkView is the superclass for views.  A view is generally an area of an
/// application's canvas devoted to displaying one or more VTK data objects.
/// Associated representations (subclasses of vtkDataRepresentation) are
/// responsible for converting the data into a displayable format.  These
/// representations are then added to the view.
///
/// For views which display only one data object at a time you may set a
/// data object or pipeline connection directly on the view itself (e.g.
/// vtkGraphLayoutView, vtkLandscapeView, vtkTreeMapView).
/// The view will internally create a vtkDataRepresentation for the data.
///
/// A view has the concept of linked selection.  If the same data is displayed
/// in multiple views, their selections may be linked by setting the same
/// vtkAnnotationLink on their representations (see vtkDataRepresentation).
/// </remarks>
public class vtkView : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkView";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkView()
	{
		MRClassNameKey = "class vtkView";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkView"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkView(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkView_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkView New()
	{
		vtkView result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkView_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkView()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkView_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkView_AddRepresentation_01(HandleRef pThis, HandleRef rep);

	/// <summary>
	/// Adds the representation to the view.
	/// </summary>
	public void AddRepresentation(vtkDataRepresentation rep)
	{
		vtkView_AddRepresentation_01(GetCppThis(), rep?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkView_AddRepresentationFromInput_02(HandleRef pThis, HandleRef input, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Convenience method which creates a simple representation with the
	/// specified input and adds it to the view.
	/// NOTE: The returned representation pointer is not reference-counted,
	/// so you MUST call Register() on the representation if you want to
	/// keep a reference to it.
	/// </summary>
	public vtkDataRepresentation AddRepresentationFromInput(vtkDataObject input)
	{
		vtkDataRepresentation vtkDataRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkView_AddRepresentationFromInput_02(GetCppThis(), input?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataRepresentation2 = (vtkDataRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataRepresentation2.Register(null);
			}
		}
		return vtkDataRepresentation2;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkView_AddRepresentationFromInputConnection_03(HandleRef pThis, HandleRef conn, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Convenience method which creates a simple representation with the
	/// connection and adds it to the view.
	/// Returns the representation internally created.
	/// NOTE: The returned representation pointer is not reference-counted,
	/// so you MUST call Register() on the representation if you want to
	/// keep a reference to it.
	/// </summary>
	public vtkDataRepresentation AddRepresentationFromInputConnection(vtkAlgorithmOutput conn)
	{
		vtkDataRepresentation vtkDataRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkView_AddRepresentationFromInputConnection_03(GetCppThis(), conn?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataRepresentation2 = (vtkDataRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataRepresentation2.Register(null);
			}
		}
		return vtkDataRepresentation2;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkView_ApplyViewTheme_04(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Apply a theme to the view.
	/// </summary>
	public virtual void ApplyViewTheme(vtkViewTheme arg0)
	{
		vtkView_ApplyViewTheme_04(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkView_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkView_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkView_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkView_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkView_GetNumberOfRepresentations_07(HandleRef pThis);

	/// <summary>
	/// Returns the number of representations from first port(0) in this view.
	/// </summary>
	public int GetNumberOfRepresentations()
	{
		return vtkView_GetNumberOfRepresentations_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkView_GetObserver_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns the observer that the subclasses can use to listen to additional
	/// events. Additionally these subclasses should override
	/// ProcessEvents() to handle these events.
	/// </summary>
	public vtkCommand GetObserver()
	{
		vtkCommand vtkCommand2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkView_GetObserver_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCommand2 = (vtkCommand)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCommand2.Register(null);
			}
		}
		return vtkCommand2;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkView_GetRepresentation_09(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The representation at a specified index.
	/// </summary>
	public vtkDataRepresentation GetRepresentation(int index)
	{
		vtkDataRepresentation vtkDataRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkView_GetRepresentation_09(GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataRepresentation2 = (vtkDataRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataRepresentation2.Register(null);
			}
		}
		return vtkDataRepresentation2;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkView_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkView_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkView_IsRepresentationPresent_11(HandleRef pThis, HandleRef rep);

	/// <summary>
	/// Check to see if a representation is present in the view.
	/// </summary>
	public bool IsRepresentationPresent(vtkDataRepresentation rep)
	{
		return (vtkView_IsRepresentationPresent_11(GetCppThis(), rep?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkView_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkView_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkView_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkView NewInstance()
	{
		vtkView result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkView_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkView_RegisterProgress_15(HandleRef pThis, HandleRef algorithm, string message);

	/// <summary>
	/// Meant for use by subclasses and vtkRepresentation subclasses.
	/// Call this method to register vtkObjects (generally
	/// vtkAlgorithm subclasses) which fire vtkCommand::ProgressEvent with the
	/// view. The view listens to vtkCommand::ProgressEvent and fires
	/// ViewProgressEvent with ViewProgressEventCallData containing the message and
	/// the progress amount. If message is not provided, then the class name for
	/// the algorithm is used.
	/// </summary>
	public void RegisterProgress(vtkObject algorithm, string message)
	{
		vtkView_RegisterProgress_15(GetCppThis(), algorithm?.GetCppThis() ?? default(HandleRef), message);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkView_RemoveAllRepresentations_16(HandleRef pThis);

	/// <summary>
	/// Removes all representations from the view.
	/// </summary>
	public void RemoveAllRepresentations()
	{
		vtkView_RemoveAllRepresentations_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkView_RemoveRepresentation_17(HandleRef pThis, HandleRef rep);

	/// <summary>
	/// Removes the representation from the view.
	/// </summary>
	public void RemoveRepresentation(vtkDataRepresentation rep)
	{
		vtkView_RemoveRepresentation_17(GetCppThis(), rep?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkView_RemoveRepresentation_18(HandleRef pThis, HandleRef rep);

	/// <summary>
	/// Removes any representation with this connection from the view.
	/// </summary>
	public void RemoveRepresentation(vtkAlgorithmOutput rep)
	{
		vtkView_RemoveRepresentation_18(GetCppThis(), rep?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkView_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkView SafeDownCast(vtkObjectBase o)
	{
		vtkView vtkView2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkView_SafeDownCast_19(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkView2 = (vtkView)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkView2.Register(null);
			}
		}
		return vtkView2;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkView_SetRepresentation_20(HandleRef pThis, HandleRef rep);

	/// <summary>
	/// Set the representation to the view.
	/// </summary>
	public void SetRepresentation(vtkDataRepresentation rep)
	{
		vtkView_SetRepresentation_20(GetCppThis(), rep?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkView_SetRepresentationFromInput_21(HandleRef pThis, HandleRef input, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Convenience method which sets the representation to the
	/// specified input and adds it to the view.
	/// NOTE: The returned representation pointer is not reference-counted,
	/// so you MUST call Register() on the representation if you want to
	/// keep a reference to it.
	/// </summary>
	public vtkDataRepresentation SetRepresentationFromInput(vtkDataObject input)
	{
		vtkDataRepresentation vtkDataRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkView_SetRepresentationFromInput_21(GetCppThis(), input?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataRepresentation2 = (vtkDataRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataRepresentation2.Register(null);
			}
		}
		return vtkDataRepresentation2;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkView_SetRepresentationFromInputConnection_22(HandleRef pThis, HandleRef conn, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Convenience method which sets the representation with the
	/// connection and adds it to the view.
	/// Returns the representation internally created.
	/// NOTE: The returned representation pointer is not reference-counted,
	/// so you MUST call Register() on the representation if you want to
	/// keep a reference to it.
	/// </summary>
	public vtkDataRepresentation SetRepresentationFromInputConnection(vtkAlgorithmOutput conn)
	{
		vtkDataRepresentation vtkDataRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkView_SetRepresentationFromInputConnection_22(GetCppThis(), conn?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataRepresentation2 = (vtkDataRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataRepresentation2.Register(null);
			}
		}
		return vtkDataRepresentation2;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkView_UnRegisterProgress_23(HandleRef pThis, HandleRef algorithm);

	/// <summary>
	/// Unregister objects previously registered with RegisterProgress.
	/// </summary>
	public void UnRegisterProgress(vtkObject algorithm)
	{
		vtkView_UnRegisterProgress_23(GetCppThis(), algorithm?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkView_Update_24(HandleRef pThis);

	/// <summary>
	/// Update the view.
	/// </summary>
	public virtual void Update()
	{
		vtkView_Update_24(GetCppThis());
	}
}
