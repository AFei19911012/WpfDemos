using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageRectilinearWipe
/// </summary>
/// <remarks>
///    make a rectilinear combination of two images.
///
/// vtkImageRectilinearWipe makes a rectilinear combination of two
/// images. The two input images must correspond in size, scalar type and
/// number of components.
/// The resulting image has four possible configurations
/// called:
///   Quad - alternate input 0 and input 1 horizontally and
///     vertically. Select this with SetWipeModeToQuad. The Position
///     specifies the location of the quad intersection.
///   Corner - 3 of one input and 1 of the other. Select the location of
///     input 0 with with SetWipeModeToLowerLeft, SetWipeModeToLowerRight,
///     SetWipeModeToUpperLeft and SetWipeModeToUpperRight. The Position
///     selects the location of the corner.
///   Horizontal - alternate input 0 and input 1 with a vertical
///     split. Select this with SetWipeModeToHorizontal. Position[0]
///     specifies the location of the vertical transition between input 0
///     and input 1.
///   Vertical - alternate input 0 and input 1 with a horizontal
///     split. Only the y The intersection point of the rectilinear points
///     is controlled with the Point ivar.
///
/// @par Thanks:
/// This work was supported by PHS Research Grant No. 1 P41 RR13218-01
/// from the National Center for Research Resources.
///
/// </remarks>
/// <seealso>
///
/// vtkImageCheckerboard
/// </seealso>
public class vtkImageRectilinearWipe : vtkThreadedImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageRectilinearWipe";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageRectilinearWipe()
	{
		MRClassNameKey = "class vtkImageRectilinearWipe";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageRectilinearWipe"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageRectilinearWipe(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageRectilinearWipe_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageRectilinearWipe New()
	{
		vtkImageRectilinearWipe result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageRectilinearWipe_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageRectilinearWipe)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageRectilinearWipe()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageRectilinearWipe_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageRectilinearWipe_GetAxis_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the location of the wipe axes. The default is X,Y (ie vector
	/// values of 0 and 1).
	/// </summary>
	public virtual int[] GetAxis()
	{
		IntPtr intPtr = vtkImageRectilinearWipe_GetAxis_01(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageRectilinearWipe_GetAxis_02(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the location of the wipe axes. The default is X,Y (ie vector
	/// values of 0 and 1).
	/// </summary>
	public virtual void GetAxis(IntPtr data)
	{
		vtkImageRectilinearWipe_GetAxis_02(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageRectilinearWipe_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageRectilinearWipe_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageRectilinearWipe_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageRectilinearWipe_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageRectilinearWipe_GetPosition_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the location of the image transition. Note that position is
	/// specified in pixels.
	/// </summary>
	public virtual int[] GetPosition()
	{
		IntPtr intPtr = vtkImageRectilinearWipe_GetPosition_05(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageRectilinearWipe_GetPosition_06(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the location of the image transition. Note that position is
	/// specified in pixels.
	/// </summary>
	public virtual void GetPosition(IntPtr data)
	{
		vtkImageRectilinearWipe_GetPosition_06(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageRectilinearWipe_GetWipe_07(HandleRef pThis);

	/// <summary>
	/// Specify the wipe mode. This mode determnis how input 0 and input
	/// 1 are combined to produce the output. Each mode uses one or both
	/// of the values stored in Position.
	/// SetWipeToQuad - alternate input 0 and input 1 horizontally and
	/// vertically. The Position specifies the location of the quad
	/// intersection.
	/// SetWipeToLowerLeft{LowerRight,UpperLeft.UpperRight} - 3 of one
	/// input and 1 of the other. Select the location of input 0 to the
	/// LowerLeft{LowerRight,UpperLeft,UpperRight}. Position
	/// selects the location of the corner.
	/// SetWipeToHorizontal - alternate input 0 and input 1 with a vertical
	/// split. Position[0] specifies the location of the vertical
	/// transition between input 0 and input 1.
	/// SetWipeToVertical - alternate input 0 and input 1 with a
	/// horizontal split. Position[1] specifies the location of the
	/// horizontal transition between input 0 and input 1.
	/// </summary>
	public virtual int GetWipe()
	{
		return vtkImageRectilinearWipe_GetWipe_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageRectilinearWipe_GetWipeMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Specify the wipe mode. This mode determnis how input 0 and input
	/// 1 are combined to produce the output. Each mode uses one or both
	/// of the values stored in Position.
	/// SetWipeToQuad - alternate input 0 and input 1 horizontally and
	/// vertically. The Position specifies the location of the quad
	/// intersection.
	/// SetWipeToLowerLeft{LowerRight,UpperLeft.UpperRight} - 3 of one
	/// input and 1 of the other. Select the location of input 0 to the
	/// LowerLeft{LowerRight,UpperLeft,UpperRight}. Position
	/// selects the location of the corner.
	/// SetWipeToHorizontal - alternate input 0 and input 1 with a vertical
	/// split. Position[0] specifies the location of the vertical
	/// transition between input 0 and input 1.
	/// SetWipeToVertical - alternate input 0 and input 1 with a
	/// horizontal split. Position[1] specifies the location of the
	/// horizontal transition between input 0 and input 1.
	/// </summary>
	public virtual int GetWipeMaxValue()
	{
		return vtkImageRectilinearWipe_GetWipeMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageRectilinearWipe_GetWipeMinValue_09(HandleRef pThis);

	/// <summary>
	/// Specify the wipe mode. This mode determnis how input 0 and input
	/// 1 are combined to produce the output. Each mode uses one or both
	/// of the values stored in Position.
	/// SetWipeToQuad - alternate input 0 and input 1 horizontally and
	/// vertically. The Position specifies the location of the quad
	/// intersection.
	/// SetWipeToLowerLeft{LowerRight,UpperLeft.UpperRight} - 3 of one
	/// input and 1 of the other. Select the location of input 0 to the
	/// LowerLeft{LowerRight,UpperLeft,UpperRight}. Position
	/// selects the location of the corner.
	/// SetWipeToHorizontal - alternate input 0 and input 1 with a vertical
	/// split. Position[0] specifies the location of the vertical
	/// transition between input 0 and input 1.
	/// SetWipeToVertical - alternate input 0 and input 1 with a
	/// horizontal split. Position[1] specifies the location of the
	/// horizontal transition between input 0 and input 1.
	/// </summary>
	public virtual int GetWipeMinValue()
	{
		return vtkImageRectilinearWipe_GetWipeMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageRectilinearWipe_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageRectilinearWipe_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageRectilinearWipe_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageRectilinearWipe_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageRectilinearWipe_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageRectilinearWipe NewInstance()
	{
		vtkImageRectilinearWipe result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageRectilinearWipe_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageRectilinearWipe)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageRectilinearWipe_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageRectilinearWipe SafeDownCast(vtkObjectBase o)
	{
		vtkImageRectilinearWipe vtkImageRectilinearWipe2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageRectilinearWipe_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageRectilinearWipe2 = (vtkImageRectilinearWipe)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageRectilinearWipe2.Register(null);
			}
		}
		return vtkImageRectilinearWipe2;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageRectilinearWipe_SetAxis_15(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Set/Get the location of the wipe axes. The default is X,Y (ie vector
	/// values of 0 and 1).
	/// </summary>
	public virtual void SetAxis(int _arg1, int _arg2)
	{
		vtkImageRectilinearWipe_SetAxis_15(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageRectilinearWipe_SetAxis_16(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the location of the wipe axes. The default is X,Y (ie vector
	/// values of 0 and 1).
	/// </summary>
	public void SetAxis(IntPtr _arg)
	{
		vtkImageRectilinearWipe_SetAxis_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageRectilinearWipe_SetInput1Data_17(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the two inputs to this filter.
	/// </summary>
	public virtual void SetInput1Data(vtkDataObject arg0)
	{
		vtkImageRectilinearWipe_SetInput1Data_17(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageRectilinearWipe_SetInput2Data_18(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the two inputs to this filter.
	/// </summary>
	public virtual void SetInput2Data(vtkDataObject arg0)
	{
		vtkImageRectilinearWipe_SetInput2Data_18(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageRectilinearWipe_SetPosition_19(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Set/Get the location of the image transition. Note that position is
	/// specified in pixels.
	/// </summary>
	public virtual void SetPosition(int _arg1, int _arg2)
	{
		vtkImageRectilinearWipe_SetPosition_19(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageRectilinearWipe_SetPosition_20(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the location of the image transition. Note that position is
	/// specified in pixels.
	/// </summary>
	public void SetPosition(IntPtr _arg)
	{
		vtkImageRectilinearWipe_SetPosition_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageRectilinearWipe_SetWipe_21(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the wipe mode. This mode determnis how input 0 and input
	/// 1 are combined to produce the output. Each mode uses one or both
	/// of the values stored in Position.
	/// SetWipeToQuad - alternate input 0 and input 1 horizontally and
	/// vertically. The Position specifies the location of the quad
	/// intersection.
	/// SetWipeToLowerLeft{LowerRight,UpperLeft.UpperRight} - 3 of one
	/// input and 1 of the other. Select the location of input 0 to the
	/// LowerLeft{LowerRight,UpperLeft,UpperRight}. Position
	/// selects the location of the corner.
	/// SetWipeToHorizontal - alternate input 0 and input 1 with a vertical
	/// split. Position[0] specifies the location of the vertical
	/// transition between input 0 and input 1.
	/// SetWipeToVertical - alternate input 0 and input 1 with a
	/// horizontal split. Position[1] specifies the location of the
	/// horizontal transition between input 0 and input 1.
	/// </summary>
	public virtual void SetWipe(int _arg)
	{
		vtkImageRectilinearWipe_SetWipe_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageRectilinearWipe_SetWipeToHorizontal_22(HandleRef pThis);

	/// <summary>
	/// Specify the wipe mode. This mode determnis how input 0 and input
	/// 1 are combined to produce the output. Each mode uses one or both
	/// of the values stored in Position.
	/// SetWipeToQuad - alternate input 0 and input 1 horizontally and
	/// vertically. The Position specifies the location of the quad
	/// intersection.
	/// SetWipeToLowerLeft{LowerRight,UpperLeft.UpperRight} - 3 of one
	/// input and 1 of the other. Select the location of input 0 to the
	/// LowerLeft{LowerRight,UpperLeft,UpperRight}. Position
	/// selects the location of the corner.
	/// SetWipeToHorizontal - alternate input 0 and input 1 with a vertical
	/// split. Position[0] specifies the location of the vertical
	/// transition between input 0 and input 1.
	/// SetWipeToVertical - alternate input 0 and input 1 with a
	/// horizontal split. Position[1] specifies the location of the
	/// horizontal transition between input 0 and input 1.
	/// </summary>
	public void SetWipeToHorizontal()
	{
		vtkImageRectilinearWipe_SetWipeToHorizontal_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageRectilinearWipe_SetWipeToLowerLeft_23(HandleRef pThis);

	/// <summary>
	/// Specify the wipe mode. This mode determnis how input 0 and input
	/// 1 are combined to produce the output. Each mode uses one or both
	/// of the values stored in Position.
	/// SetWipeToQuad - alternate input 0 and input 1 horizontally and
	/// vertically. The Position specifies the location of the quad
	/// intersection.
	/// SetWipeToLowerLeft{LowerRight,UpperLeft.UpperRight} - 3 of one
	/// input and 1 of the other. Select the location of input 0 to the
	/// LowerLeft{LowerRight,UpperLeft,UpperRight}. Position
	/// selects the location of the corner.
	/// SetWipeToHorizontal - alternate input 0 and input 1 with a vertical
	/// split. Position[0] specifies the location of the vertical
	/// transition between input 0 and input 1.
	/// SetWipeToVertical - alternate input 0 and input 1 with a
	/// horizontal split. Position[1] specifies the location of the
	/// horizontal transition between input 0 and input 1.
	/// </summary>
	public void SetWipeToLowerLeft()
	{
		vtkImageRectilinearWipe_SetWipeToLowerLeft_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageRectilinearWipe_SetWipeToLowerRight_24(HandleRef pThis);

	/// <summary>
	/// Specify the wipe mode. This mode determnis how input 0 and input
	/// 1 are combined to produce the output. Each mode uses one or both
	/// of the values stored in Position.
	/// SetWipeToQuad - alternate input 0 and input 1 horizontally and
	/// vertically. The Position specifies the location of the quad
	/// intersection.
	/// SetWipeToLowerLeft{LowerRight,UpperLeft.UpperRight} - 3 of one
	/// input and 1 of the other. Select the location of input 0 to the
	/// LowerLeft{LowerRight,UpperLeft,UpperRight}. Position
	/// selects the location of the corner.
	/// SetWipeToHorizontal - alternate input 0 and input 1 with a vertical
	/// split. Position[0] specifies the location of the vertical
	/// transition between input 0 and input 1.
	/// SetWipeToVertical - alternate input 0 and input 1 with a
	/// horizontal split. Position[1] specifies the location of the
	/// horizontal transition between input 0 and input 1.
	/// </summary>
	public void SetWipeToLowerRight()
	{
		vtkImageRectilinearWipe_SetWipeToLowerRight_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageRectilinearWipe_SetWipeToQuad_25(HandleRef pThis);

	/// <summary>
	/// Specify the wipe mode. This mode determnis how input 0 and input
	/// 1 are combined to produce the output. Each mode uses one or both
	/// of the values stored in Position.
	/// SetWipeToQuad - alternate input 0 and input 1 horizontally and
	/// vertically. The Position specifies the location of the quad
	/// intersection.
	/// SetWipeToLowerLeft{LowerRight,UpperLeft.UpperRight} - 3 of one
	/// input and 1 of the other. Select the location of input 0 to the
	/// LowerLeft{LowerRight,UpperLeft,UpperRight}. Position
	/// selects the location of the corner.
	/// SetWipeToHorizontal - alternate input 0 and input 1 with a vertical
	/// split. Position[0] specifies the location of the vertical
	/// transition between input 0 and input 1.
	/// SetWipeToVertical - alternate input 0 and input 1 with a
	/// horizontal split. Position[1] specifies the location of the
	/// horizontal transition between input 0 and input 1.
	/// </summary>
	public void SetWipeToQuad()
	{
		vtkImageRectilinearWipe_SetWipeToQuad_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageRectilinearWipe_SetWipeToUpperLeft_26(HandleRef pThis);

	/// <summary>
	/// Specify the wipe mode. This mode determnis how input 0 and input
	/// 1 are combined to produce the output. Each mode uses one or both
	/// of the values stored in Position.
	/// SetWipeToQuad - alternate input 0 and input 1 horizontally and
	/// vertically. The Position specifies the location of the quad
	/// intersection.
	/// SetWipeToLowerLeft{LowerRight,UpperLeft.UpperRight} - 3 of one
	/// input and 1 of the other. Select the location of input 0 to the
	/// LowerLeft{LowerRight,UpperLeft,UpperRight}. Position
	/// selects the location of the corner.
	/// SetWipeToHorizontal - alternate input 0 and input 1 with a vertical
	/// split. Position[0] specifies the location of the vertical
	/// transition between input 0 and input 1.
	/// SetWipeToVertical - alternate input 0 and input 1 with a
	/// horizontal split. Position[1] specifies the location of the
	/// horizontal transition between input 0 and input 1.
	/// </summary>
	public void SetWipeToUpperLeft()
	{
		vtkImageRectilinearWipe_SetWipeToUpperLeft_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageRectilinearWipe_SetWipeToUpperRight_27(HandleRef pThis);

	/// <summary>
	/// Specify the wipe mode. This mode determnis how input 0 and input
	/// 1 are combined to produce the output. Each mode uses one or both
	/// of the values stored in Position.
	/// SetWipeToQuad - alternate input 0 and input 1 horizontally and
	/// vertically. The Position specifies the location of the quad
	/// intersection.
	/// SetWipeToLowerLeft{LowerRight,UpperLeft.UpperRight} - 3 of one
	/// input and 1 of the other. Select the location of input 0 to the
	/// LowerLeft{LowerRight,UpperLeft,UpperRight}. Position
	/// selects the location of the corner.
	/// SetWipeToHorizontal - alternate input 0 and input 1 with a vertical
	/// split. Position[0] specifies the location of the vertical
	/// transition between input 0 and input 1.
	/// SetWipeToVertical - alternate input 0 and input 1 with a
	/// horizontal split. Position[1] specifies the location of the
	/// horizontal transition between input 0 and input 1.
	/// </summary>
	public void SetWipeToUpperRight()
	{
		vtkImageRectilinearWipe_SetWipeToUpperRight_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageRectilinearWipe_SetWipeToVertical_28(HandleRef pThis);

	/// <summary>
	/// Specify the wipe mode. This mode determnis how input 0 and input
	/// 1 are combined to produce the output. Each mode uses one or both
	/// of the values stored in Position.
	/// SetWipeToQuad - alternate input 0 and input 1 horizontally and
	/// vertically. The Position specifies the location of the quad
	/// intersection.
	/// SetWipeToLowerLeft{LowerRight,UpperLeft.UpperRight} - 3 of one
	/// input and 1 of the other. Select the location of input 0 to the
	/// LowerLeft{LowerRight,UpperLeft,UpperRight}. Position
	/// selects the location of the corner.
	/// SetWipeToHorizontal - alternate input 0 and input 1 with a vertical
	/// split. Position[0] specifies the location of the vertical
	/// transition between input 0 and input 1.
	/// SetWipeToVertical - alternate input 0 and input 1 with a
	/// horizontal split. Position[1] specifies the location of the
	/// horizontal transition between input 0 and input 1.
	/// </summary>
	public void SetWipeToVertical()
	{
		vtkImageRectilinearWipe_SetWipeToVertical_28(GetCppThis());
	}
}
