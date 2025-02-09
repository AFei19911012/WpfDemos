using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDataRepresentation
/// </summary>
/// <remarks>
///    The superclass for all representations
///
///
/// vtkDataRepresentation the superclass for representations of data objects.
/// This class itself may be instantiated and used as a representation
/// that simply holds a connection to a pipeline.
///
/// If there are multiple representations present in a view, you should use
/// a subclass of vtkDataRepresentation.  The representation is
/// responsible for taking the input pipeline connection and converting it
/// to an object usable by a view.  In the most common case, the representation
/// will contain the pipeline necessary to convert a data object into an actor
/// or set of actors.
///
/// The representation has a concept of a selection.  If the user performs a
/// selection operation on the view, the view forwards this on to its
/// representations.  The representation is responsible for displaying that
/// selection in an appropriate way.
///
/// Representation selections may also be linked.  The representation shares
/// the selection by converting it into a view-independent format, then
/// setting the selection on its vtkAnnotationLink.  Other representations
/// sharing the same selection link instance will get the same selection
/// from the selection link when the view is updated.  The application is
/// responsible for linking representations as appropriate by setting the
/// same vtkAnnotationLink on each linked representation.
/// </remarks>
public class vtkDataRepresentation : vtkPassInputTypeAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDataRepresentation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDataRepresentation()
	{
		MRClassNameKey = "class vtkDataRepresentation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataRepresentation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDataRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDataRepresentation New()
	{
		vtkDataRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDataRepresentation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDataRepresentation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDataRepresentation_Annotate_01(HandleRef pThis, HandleRef view, HandleRef annotations);

	/// <summary>
	/// Analogous to Select(). The view calls this method when it needs to
	/// change the underlying annotations (some views might perform the
	/// creation of annotations). The representation takes the annotations
	/// and converts them into a selection on its data by calling ConvertAnnotations,
	/// then calls UpdateAnnotations with the converted selection.
	/// Subclasses should not override this method, but should instead
	/// override ConvertSelection.
	/// The optional third argument specifies whether the selection should be
	/// added to the previous selection on this representation.
	/// </summary>
	public void Annotate(vtkView view, vtkAnnotationLayers annotations)
	{
		vtkDataRepresentation_Annotate_01(GetCppThis(), view?.GetCppThis() ?? default(HandleRef), annotations?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataRepresentation_Annotate_02(HandleRef pThis, HandleRef view, HandleRef annotations, byte extend);

	/// <summary>
	/// Analogous to Select(). The view calls this method when it needs to
	/// change the underlying annotations (some views might perform the
	/// creation of annotations). The representation takes the annotations
	/// and converts them into a selection on its data by calling ConvertAnnotations,
	/// then calls UpdateAnnotations with the converted selection.
	/// Subclasses should not override this method, but should instead
	/// override ConvertSelection.
	/// The optional third argument specifies whether the selection should be
	/// added to the previous selection on this representation.
	/// </summary>
	public void Annotate(vtkView view, vtkAnnotationLayers annotations, bool extend)
	{
		vtkDataRepresentation_Annotate_02(GetCppThis(), view?.GetCppThis() ?? default(HandleRef), annotations?.GetCppThis() ?? default(HandleRef), (byte)(extend ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataRepresentation_ApplyViewTheme_03(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Apply a theme to this representation.
	/// Subclasses should override this method.
	/// </summary>
	public virtual void ApplyViewTheme(vtkViewTheme arg0)
	{
		vtkDataRepresentation_ApplyViewTheme_03(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataRepresentation_ConvertSelection_04(HandleRef pThis, HandleRef view, HandleRef selection, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Convert the selection to a type appropriate for sharing with other
	/// representations through vtkAnnotationLink, possibly using the view.
	/// For the superclass, we just return the same selection.
	/// Subclasses may do something more fancy, like convert the selection
	/// from a frustrum to a list of pedigree ids.  If the selection cannot
	/// be applied to this representation, return nullptr.
	/// </summary>
	public virtual vtkSelection ConvertSelection(vtkView view, vtkSelection selection)
	{
		vtkSelection vtkSelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataRepresentation_ConvertSelection_04(GetCppThis(), view?.GetCppThis() ?? default(HandleRef), selection?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSelection2 = (vtkSelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSelection2.Register(null);
			}
		}
		return vtkSelection2;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataRepresentation_GetAnnotationLink_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The annotation link for this representation.
	/// To link annotations, set the same vtkAnnotationLink object in
	/// multiple representations.
	/// </summary>
	public vtkAnnotationLink GetAnnotationLink()
	{
		vtkAnnotationLink vtkAnnotationLink2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataRepresentation_GetAnnotationLink_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAnnotationLink2 = (vtkAnnotationLink)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAnnotationLink2.Register(null);
			}
		}
		return vtkAnnotationLink2;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataRepresentation_GetInputConnection_06(HandleRef pThis, int port, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Convenience override method for obtaining the input connection
	/// without specifying the port or index.
	/// </summary>
	public new vtkAlgorithmOutput GetInputConnection(int port, int index)
	{
		vtkAlgorithmOutput vtkAlgorithmOutput2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataRepresentation_GetInputConnection_06(GetCppThis(), port, index, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAlgorithmOutput2 = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAlgorithmOutput2.Register(null);
			}
		}
		return vtkAlgorithmOutput2;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataRepresentation_GetInternalAnnotationOutputPort_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The output port that contains the annotations whose selections are
	/// localized for a particular input data object.
	/// This should be used when connecting the internal pipelines.
	/// </summary>
	public virtual vtkAlgorithmOutput GetInternalAnnotationOutputPort()
	{
		vtkAlgorithmOutput vtkAlgorithmOutput2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataRepresentation_GetInternalAnnotationOutputPort_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAlgorithmOutput2 = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAlgorithmOutput2.Register(null);
			}
		}
		return vtkAlgorithmOutput2;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataRepresentation_GetInternalAnnotationOutputPort_08(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The output port that contains the annotations whose selections are
	/// localized for a particular input data object.
	/// This should be used when connecting the internal pipelines.
	/// </summary>
	public virtual vtkAlgorithmOutput GetInternalAnnotationOutputPort(int port)
	{
		vtkAlgorithmOutput vtkAlgorithmOutput2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataRepresentation_GetInternalAnnotationOutputPort_08(GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAlgorithmOutput2 = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAlgorithmOutput2.Register(null);
			}
		}
		return vtkAlgorithmOutput2;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataRepresentation_GetInternalAnnotationOutputPort_09(HandleRef pThis, int port, int conn, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The output port that contains the annotations whose selections are
	/// localized for a particular input data object.
	/// This should be used when connecting the internal pipelines.
	/// </summary>
	public virtual vtkAlgorithmOutput GetInternalAnnotationOutputPort(int port, int conn)
	{
		vtkAlgorithmOutput vtkAlgorithmOutput2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataRepresentation_GetInternalAnnotationOutputPort_09(GetCppThis(), port, conn, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAlgorithmOutput2 = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAlgorithmOutput2.Register(null);
			}
		}
		return vtkAlgorithmOutput2;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataRepresentation_GetInternalOutputPort_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieves an output port for the input data object at the specified port
	/// and connection index. This may be connected to the representation's
	/// internal pipeline.
	/// </summary>
	public virtual vtkAlgorithmOutput GetInternalOutputPort()
	{
		vtkAlgorithmOutput vtkAlgorithmOutput2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataRepresentation_GetInternalOutputPort_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAlgorithmOutput2 = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAlgorithmOutput2.Register(null);
			}
		}
		return vtkAlgorithmOutput2;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataRepresentation_GetInternalOutputPort_11(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieves an output port for the input data object at the specified port
	/// and connection index. This may be connected to the representation's
	/// internal pipeline.
	/// </summary>
	public virtual vtkAlgorithmOutput GetInternalOutputPort(int port)
	{
		vtkAlgorithmOutput vtkAlgorithmOutput2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataRepresentation_GetInternalOutputPort_11(GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAlgorithmOutput2 = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAlgorithmOutput2.Register(null);
			}
		}
		return vtkAlgorithmOutput2;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataRepresentation_GetInternalOutputPort_12(HandleRef pThis, int port, int conn, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Retrieves an output port for the input data object at the specified port
	/// and connection index. This may be connected to the representation's
	/// internal pipeline.
	/// </summary>
	public virtual vtkAlgorithmOutput GetInternalOutputPort(int port, int conn)
	{
		vtkAlgorithmOutput vtkAlgorithmOutput2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataRepresentation_GetInternalOutputPort_12(GetCppThis(), port, conn, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAlgorithmOutput2 = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAlgorithmOutput2.Register(null);
			}
		}
		return vtkAlgorithmOutput2;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataRepresentation_GetInternalSelectionOutputPort_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The output port that contains the selection associated with the
	/// current annotation (normally the interactive selection).
	/// This should be used when connecting the internal pipelines.
	/// </summary>
	public virtual vtkAlgorithmOutput GetInternalSelectionOutputPort()
	{
		vtkAlgorithmOutput vtkAlgorithmOutput2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataRepresentation_GetInternalSelectionOutputPort_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAlgorithmOutput2 = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAlgorithmOutput2.Register(null);
			}
		}
		return vtkAlgorithmOutput2;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataRepresentation_GetInternalSelectionOutputPort_14(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The output port that contains the selection associated with the
	/// current annotation (normally the interactive selection).
	/// This should be used when connecting the internal pipelines.
	/// </summary>
	public virtual vtkAlgorithmOutput GetInternalSelectionOutputPort(int port)
	{
		vtkAlgorithmOutput vtkAlgorithmOutput2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataRepresentation_GetInternalSelectionOutputPort_14(GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAlgorithmOutput2 = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAlgorithmOutput2.Register(null);
			}
		}
		return vtkAlgorithmOutput2;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataRepresentation_GetInternalSelectionOutputPort_15(HandleRef pThis, int port, int conn, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The output port that contains the selection associated with the
	/// current annotation (normally the interactive selection).
	/// This should be used when connecting the internal pipelines.
	/// </summary>
	public virtual vtkAlgorithmOutput GetInternalSelectionOutputPort(int port, int conn)
	{
		vtkAlgorithmOutput vtkAlgorithmOutput2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataRepresentation_GetInternalSelectionOutputPort_15(GetCppThis(), port, conn, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAlgorithmOutput2 = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAlgorithmOutput2.Register(null);
			}
		}
		return vtkAlgorithmOutput2;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataRepresentation_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDataRepresentation_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataRepresentation_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDataRepresentation_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDataRepresentation_GetSelectable_18(HandleRef pThis);

	/// <summary>
	/// Whether this representation is able to handle a selection.
	/// Default is true.
	/// </summary>
	public virtual bool GetSelectable()
	{
		return (vtkDataRepresentation_GetSelectable_18(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataRepresentation_GetSelectionArrayName_19(HandleRef pThis);

	/// <summary>
	/// If a VALUES selection, the array used to produce a selection.
	/// </summary>
	public virtual string GetSelectionArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkDataRepresentation_GetSelectionArrayName_19(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataRepresentation_GetSelectionArrayNames_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// If a VALUES selection, the arrays used to produce a selection.
	/// </summary>
	public virtual vtkStringArray GetSelectionArrayNames()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataRepresentation_GetSelectionArrayNames_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStringArray2 = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStringArray2.Register(null);
			}
		}
		return vtkStringArray2;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataRepresentation_GetSelectionType_21(HandleRef pThis);

	/// <summary>
	/// Set the selection type produced by this view.
	/// This should be one of the content type constants defined in
	/// vtkSelectionNode.h. Common values are
	/// vtkSelectionNode::INDICES
	/// vtkSelectionNode::PEDIGREEIDS
	/// vtkSelectionNode::VALUES
	/// </summary>
	public virtual int GetSelectionType()
	{
		return vtkDataRepresentation_GetSelectionType_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataRepresentation_IsA_22(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDataRepresentation_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataRepresentation_IsTypeOf_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDataRepresentation_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataRepresentation_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDataRepresentation NewInstance()
	{
		vtkDataRepresentation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataRepresentation_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataRepresentation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataRepresentation_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDataRepresentation SafeDownCast(vtkObjectBase o)
	{
		vtkDataRepresentation vtkDataRepresentation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataRepresentation_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDataRepresentation_Select_27(HandleRef pThis, HandleRef view, HandleRef selection);

	/// <summary>
	/// The view calls this method when a selection occurs.
	/// The representation takes this selection and converts it into
	/// a selection on its data by calling ConvertSelection,
	/// then calls UpdateSelection with the converted selection.
	/// Subclasses should not override this method, but should instead
	/// override ConvertSelection.
	/// The optional third argument specifies whether the selection should be
	/// added to the previous selection on this representation.
	/// </summary>
	public void Select(vtkView view, vtkSelection selection)
	{
		vtkDataRepresentation_Select_27(GetCppThis(), view?.GetCppThis() ?? default(HandleRef), selection?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataRepresentation_Select_28(HandleRef pThis, HandleRef view, HandleRef selection, byte extend);

	/// <summary>
	/// The view calls this method when a selection occurs.
	/// The representation takes this selection and converts it into
	/// a selection on its data by calling ConvertSelection,
	/// then calls UpdateSelection with the converted selection.
	/// Subclasses should not override this method, but should instead
	/// override ConvertSelection.
	/// The optional third argument specifies whether the selection should be
	/// added to the previous selection on this representation.
	/// </summary>
	public void Select(vtkView view, vtkSelection selection, bool extend)
	{
		vtkDataRepresentation_Select_28(GetCppThis(), view?.GetCppThis() ?? default(HandleRef), selection?.GetCppThis() ?? default(HandleRef), (byte)(extend ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataRepresentation_SelectableOff_29(HandleRef pThis);

	/// <summary>
	/// Whether this representation is able to handle a selection.
	/// Default is true.
	/// </summary>
	public virtual void SelectableOff()
	{
		vtkDataRepresentation_SelectableOff_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataRepresentation_SelectableOn_30(HandleRef pThis);

	/// <summary>
	/// Whether this representation is able to handle a selection.
	/// Default is true.
	/// </summary>
	public virtual void SelectableOn()
	{
		vtkDataRepresentation_SelectableOn_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataRepresentation_SetAnnotationLink_31(HandleRef pThis, HandleRef link);

	/// <summary>
	/// The annotation link for this representation.
	/// To link annotations, set the same vtkAnnotationLink object in
	/// multiple representations.
	/// </summary>
	public void SetAnnotationLink(vtkAnnotationLink link)
	{
		vtkDataRepresentation_SetAnnotationLink_31(GetCppThis(), link?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataRepresentation_SetSelectable_32(HandleRef pThis, byte _arg);

	/// <summary>
	/// Whether this representation is able to handle a selection.
	/// Default is true.
	/// </summary>
	public virtual void SetSelectable(bool _arg)
	{
		vtkDataRepresentation_SetSelectable_32(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataRepresentation_SetSelectionArrayName_33(HandleRef pThis, string name);

	/// <summary>
	/// If a VALUES selection, the array used to produce a selection.
	/// </summary>
	public virtual void SetSelectionArrayName(string name)
	{
		vtkDataRepresentation_SetSelectionArrayName_33(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataRepresentation_SetSelectionArrayNames_34(HandleRef pThis, HandleRef names);

	/// <summary>
	/// If a VALUES selection, the arrays used to produce a selection.
	/// </summary>
	public virtual void SetSelectionArrayNames(vtkStringArray names)
	{
		vtkDataRepresentation_SetSelectionArrayNames_34(GetCppThis(), names?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataRepresentation_SetSelectionType_35(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the selection type produced by this view.
	/// This should be one of the content type constants defined in
	/// vtkSelectionNode.h. Common values are
	/// vtkSelectionNode::INDICES
	/// vtkSelectionNode::PEDIGREEIDS
	/// vtkSelectionNode::VALUES
	/// </summary>
	public virtual void SetSelectionType(int _arg)
	{
		vtkDataRepresentation_SetSelectionType_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataRepresentation_UpdateAnnotations_36(HandleRef pThis, HandleRef annotations);

	/// <summary>
	/// Updates the selection in the selection link and fires a selection
	/// change event. Subclasses should not override this method,
	/// but should instead override ConvertSelection.
	/// The optional second argument specifies whether the selection should be
	/// added to the previous selection on this representation.
	/// </summary>
	public void UpdateAnnotations(vtkAnnotationLayers annotations)
	{
		vtkDataRepresentation_UpdateAnnotations_36(GetCppThis(), annotations?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataRepresentation_UpdateAnnotations_37(HandleRef pThis, HandleRef annotations, byte extend);

	/// <summary>
	/// Updates the selection in the selection link and fires a selection
	/// change event. Subclasses should not override this method,
	/// but should instead override ConvertSelection.
	/// The optional second argument specifies whether the selection should be
	/// added to the previous selection on this representation.
	/// </summary>
	public void UpdateAnnotations(vtkAnnotationLayers annotations, bool extend)
	{
		vtkDataRepresentation_UpdateAnnotations_37(GetCppThis(), annotations?.GetCppThis() ?? default(HandleRef), (byte)(extend ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataRepresentation_UpdateSelection_38(HandleRef pThis, HandleRef selection);

	/// <summary>
	/// Updates the selection in the selection link and fires a selection
	/// change event. Subclasses should not override this method,
	/// but should instead override ConvertSelection.
	/// The optional second argument specifies whether the selection should be
	/// added to the previous selection on this representation.
	/// </summary>
	public void UpdateSelection(vtkSelection selection)
	{
		vtkDataRepresentation_UpdateSelection_38(GetCppThis(), selection?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ViewsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataRepresentation_UpdateSelection_39(HandleRef pThis, HandleRef selection, byte extend);

	/// <summary>
	/// Updates the selection in the selection link and fires a selection
	/// change event. Subclasses should not override this method,
	/// but should instead override ConvertSelection.
	/// The optional second argument specifies whether the selection should be
	/// added to the previous selection on this representation.
	/// </summary>
	public void UpdateSelection(vtkSelection selection, bool extend)
	{
		vtkDataRepresentation_UpdateSelection_39(GetCppThis(), selection?.GetCppThis() ?? default(HandleRef), (byte)(extend ? 1u : 0u));
	}
}
