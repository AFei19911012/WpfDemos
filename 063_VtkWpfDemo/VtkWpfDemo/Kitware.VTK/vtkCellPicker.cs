using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCellPicker
/// </summary>
/// <remarks>
///    ray-cast cell picker for all kinds of Prop3Ds
///
/// vtkCellPicker will shoot a ray into a 3D scene and return information
/// about the first object that the ray hits.  It works for all Prop3Ds.
/// For vtkVolume objects, it shoots a ray into the volume and returns
/// the point where the ray intersects an isosurface of a chosen opacity.
/// For vtkImage objects, it intersects the ray with the displayed
/// slice. For vtkActor objects, it intersects the actor's polygons.
/// If the object's mapper has ClippingPlanes, then it takes the clipping
/// into account, and will return the Id of the clipping plane that was
/// intersected.
/// For all prop types, it returns point and cell information, plus the
/// normal of the surface that was intersected at the pick position.  For
/// volumes and images, it also returns (i,j,k) coordinates for the point
/// and the cell that were picked.
///
/// </remarks>
/// <seealso>
///
/// vtkPicker vtkPointPicker vtkVolumePicker
///
/// @par Thanks:
/// This class was contributed to VTK by David Gobbi on behalf of Atamai Inc.,
/// as an enhancement to the original vtkCellPicker.
/// </seealso>
public class vtkCellPicker : vtkPicker
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCellPicker";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCellPicker()
	{
		MRClassNameKey = "class vtkCellPicker";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellPicker"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCellPicker(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellPicker_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCellPicker New()
	{
		vtkCellPicker result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellPicker_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCellPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCellPicker()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCellPicker_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkCellPicker_AddLocator_01(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Add a locator for one of the data sets that will be included in the
	/// scene.  You must set up the locator with exactly the same data set
	/// that was input to the mapper of one or more of the actors in the
	/// scene. Note that if you try to add the
	/// same locator to the picker twice, the second addition will be ignored.
	/// </summary>
	public void AddLocator(vtkAbstractCellLocator locator)
	{
		vtkCellPicker_AddLocator_01(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellPicker_GetCellIJK_02(HandleRef pThis);

	/// <summary>
	/// Get the structured coordinates of the cell at the PickPosition.
	/// Only valid for image actors and volumes with vtkImageData.
	/// Combine this with the PCoords to get the position within the cell.
	/// </summary>
	public virtual int[] GetCellIJK()
	{
		IntPtr intPtr = vtkCellPicker_GetCellIJK_02(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellPicker_GetCellIJK_03(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

	/// <summary>
	/// Get the structured coordinates of the cell at the PickPosition.
	/// Only valid for image actors and volumes with vtkImageData.
	/// Combine this with the PCoords to get the position within the cell.
	/// </summary>
	public virtual void GetCellIJK(ref int _arg1, ref int _arg2, ref int _arg3)
	{
		vtkCellPicker_GetCellIJK_03(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellPicker_GetCellIJK_04(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the structured coordinates of the cell at the PickPosition.
	/// Only valid for image actors and volumes with vtkImageData.
	/// Combine this with the PCoords to get the position within the cell.
	/// </summary>
	public virtual void GetCellIJK(IntPtr _arg)
	{
		vtkCellPicker_GetCellIJK_04(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellPicker_GetCellId_05(HandleRef pThis);

	/// <summary>
	/// Get the id of the picked cell. If CellId = -1, nothing was picked.
	/// </summary>
	public virtual long GetCellId()
	{
		return vtkCellPicker_GetCellId_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellPicker_GetClippingPlaneId_06(HandleRef pThis);

	/// <summary>
	/// Get the index of the clipping plane that was intersected during
	/// the pick.  This will be set regardless of whether PickClippingPlanes
	/// is On, all that is required is that the pick intersected a clipping
	/// plane of the Prop3D that was picked.  The result will be -1 if the
	/// Prop3D that was picked has no clipping planes, or if the ray didn't
	/// intersect the planes.
	/// </summary>
	public virtual int GetClippingPlaneId()
	{
		return vtkCellPicker_GetClippingPlaneId_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellPicker_GetMapperNormal_07(HandleRef pThis);

	/// <summary>
	/// Return the normal of the surface at the PickPosition in mapper
	/// coordinates.  The result is undefined if no prop was picked.
	/// </summary>
	public virtual double[] GetMapperNormal()
	{
		IntPtr intPtr = vtkCellPicker_GetMapperNormal_07(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellPicker_GetMapperNormal_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Return the normal of the surface at the PickPosition in mapper
	/// coordinates.  The result is undefined if no prop was picked.
	/// </summary>
	public virtual void GetMapperNormal(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkCellPicker_GetMapperNormal_08(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellPicker_GetMapperNormal_09(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Return the normal of the surface at the PickPosition in mapper
	/// coordinates.  The result is undefined if no prop was picked.
	/// </summary>
	public virtual void GetMapperNormal(IntPtr _arg)
	{
		vtkCellPicker_GetMapperNormal_09(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellPicker_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCellPicker_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellPicker_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCellPicker_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellPicker_GetPCoords_12(HandleRef pThis);

	/// <summary>
	/// Get the parametric coordinates of the picked cell. Only valid if
	/// a prop was picked.  The PCoords can be used to compute the weights
	/// that are needed to interpolate data values within the cell.
	/// </summary>
	public virtual double[] GetPCoords()
	{
		IntPtr intPtr = vtkCellPicker_GetPCoords_12(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellPicker_GetPCoords_13(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Get the parametric coordinates of the picked cell. Only valid if
	/// a prop was picked.  The PCoords can be used to compute the weights
	/// that are needed to interpolate data values within the cell.
	/// </summary>
	public virtual void GetPCoords(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkCellPicker_GetPCoords_13(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellPicker_GetPCoords_14(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the parametric coordinates of the picked cell. Only valid if
	/// a prop was picked.  The PCoords can be used to compute the weights
	/// that are needed to interpolate data values within the cell.
	/// </summary>
	public virtual void GetPCoords(IntPtr _arg)
	{
		vtkCellPicker_GetPCoords_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellPicker_GetPickClippingPlanes_15(HandleRef pThis);

	/// <summary>
	/// The PickClippingPlanes setting controls how clipping planes are
	/// handled by the pick.  If it is On, then the clipping planes become
	/// pickable objects, even though they are usually invisible.  This
	/// means that if the pick ray intersects a clipping plane before it
	/// hits anything else, the pick will stop at that clipping plane.
	/// The GetProp3D() and GetMapper() methods will return the Prop3D
	/// and Mapper that the clipping plane belongs to.  The
	/// GetClippingPlaneId() method will return the index of the clipping
	/// plane so that you can retrieve it from the mapper, or -1 if no
	/// clipping plane was picked.
	/// </summary>
	public virtual int GetPickClippingPlanes()
	{
		return vtkCellPicker_GetPickClippingPlanes_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellPicker_GetPickNormal_16(HandleRef pThis);

	/// <summary>
	/// Return the normal of the picked surface at the PickPosition.  If no
	/// surface was picked, then a vector pointing back at the camera is
	/// returned.
	/// </summary>
	public virtual double[] GetPickNormal()
	{
		IntPtr intPtr = vtkCellPicker_GetPickNormal_16(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellPicker_GetPickNormal_17(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Return the normal of the picked surface at the PickPosition.  If no
	/// surface was picked, then a vector pointing back at the camera is
	/// returned.
	/// </summary>
	public virtual void GetPickNormal(IntPtr data)
	{
		vtkCellPicker_GetPickNormal_17(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellPicker_GetPickTextureData_18(HandleRef pThis);

	/// <summary>
	/// If this is "On" and if the picked prop has a texture, then the data
	/// returned by GetDataSet() will be the texture's data instead of the
	/// mapper's data.  The GetPointId(), GetCellId(), GetPCoords() etc. will
	/// all return information for use with the texture's data.  If the picked
	/// prop does not have any texture, then GetDataSet() will return the
	/// mapper's data instead and GetPointId() etc. will return information
	/// related to the mapper's data.  The default value of PickTextureData
	/// is "Off".
	/// </summary>
	public virtual int GetPickTextureData()
	{
		return vtkCellPicker_GetPickTextureData_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellPicker_GetPointIJK_19(HandleRef pThis);

	/// <summary>
	/// Get the structured coordinates of the point at the PickPosition.
	/// Only valid for image actors and volumes with vtkImageData.
	/// </summary>
	public virtual int[] GetPointIJK()
	{
		IntPtr intPtr = vtkCellPicker_GetPointIJK_19(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellPicker_GetPointIJK_20(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

	/// <summary>
	/// Get the structured coordinates of the point at the PickPosition.
	/// Only valid for image actors and volumes with vtkImageData.
	/// </summary>
	public virtual void GetPointIJK(ref int _arg1, ref int _arg2, ref int _arg3)
	{
		vtkCellPicker_GetPointIJK_20(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellPicker_GetPointIJK_21(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the structured coordinates of the point at the PickPosition.
	/// Only valid for image actors and volumes with vtkImageData.
	/// </summary>
	public virtual void GetPointIJK(IntPtr _arg)
	{
		vtkCellPicker_GetPointIJK_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCellPicker_GetPointId_22(HandleRef pThis);

	/// <summary>
	/// Get the id of the picked point. If PointId = -1, nothing was picked.
	/// This point will be a member of any cell that is picked.
	/// </summary>
	public virtual long GetPointId()
	{
		return vtkCellPicker_GetPointId_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellPicker_GetSubId_23(HandleRef pThis);

	/// <summary>
	/// Get the subId of the picked cell. This is useful, for example, if
	/// the data is made of triangle strips. If SubId = -1, nothing was picked.
	/// </summary>
	public virtual int GetSubId()
	{
		return vtkCellPicker_GetSubId_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellPicker_GetTexture_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the texture that was picked.  This will always be set if the
	/// picked prop has a texture, and will always be null otherwise.
	/// </summary>
	public vtkTexture GetTexture()
	{
		vtkTexture vtkTexture2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellPicker_GetTexture_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTexture2 = (vtkTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTexture2.Register(null);
			}
		}
		return vtkTexture2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellPicker_GetUseVolumeGradientOpacity_25(HandleRef pThis);

	/// <summary>
	/// Use the product of the scalar and gradient opacity functions when
	/// computing the opacity isovalue, instead of just using the scalar
	/// opacity. This parameter is only relevant to volume picking and
	/// is off by default.
	/// </summary>
	public virtual int GetUseVolumeGradientOpacity()
	{
		return vtkCellPicker_GetUseVolumeGradientOpacity_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCellPicker_GetVolumeOpacityIsovalue_26(HandleRef pThis);

	/// <summary>
	/// Set the opacity isovalue to use for defining volume surfaces.  The
	/// pick will occur at the location along the pick ray where the
	/// opacity of the volume is equal to this isovalue.  If you want to do
	/// the pick based on an actual data isovalue rather than the opacity,
	/// then pass the data value through the scalar opacity function before
	/// using this method.
	/// </summary>
	public virtual double GetVolumeOpacityIsovalue()
	{
		return vtkCellPicker_GetVolumeOpacityIsovalue_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellPicker_IsA_27(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCellPicker_IsA_27(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellPicker_IsTypeOf_28(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCellPicker_IsTypeOf_28(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellPicker_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCellPicker NewInstance()
	{
		vtkCellPicker result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellPicker_NewInstance_30(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCellPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellPicker_Pick_31(HandleRef pThis, double selectionX, double selectionY, double selectionZ, HandleRef renderer);

	/// <summary>
	/// Perform pick operation with selection point provided. Normally the
	/// first two values are the (x,y) pixel coordinates for the pick, and
	/// the third value is z=0. The return value will be non-zero if
	/// something was successfully picked.
	/// </summary>
	public override int Pick(double selectionX, double selectionY, double selectionZ, vtkRenderer renderer)
	{
		return vtkCellPicker_Pick_31(GetCppThis(), selectionX, selectionY, selectionZ, renderer?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCellPicker_Pick3DRay_32(HandleRef pThis, IntPtr selectionPt, IntPtr orient, HandleRef ren);

	/// <summary>
	/// Perform pick operation with selection point provided. The
	/// selectionPt is in world coordinates.
	/// Return non-zero if something was successfully picked.
	/// </summary>
	public override int Pick3DRay(IntPtr selectionPt, IntPtr orient, vtkRenderer ren)
	{
		return vtkCellPicker_Pick3DRay_32(GetCppThis(), selectionPt, orient, ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellPicker_PickClippingPlanesOff_33(HandleRef pThis);

	/// <summary>
	/// The PickClippingPlanes setting controls how clipping planes are
	/// handled by the pick.  If it is On, then the clipping planes become
	/// pickable objects, even though they are usually invisible.  This
	/// means that if the pick ray intersects a clipping plane before it
	/// hits anything else, the pick will stop at that clipping plane.
	/// The GetProp3D() and GetMapper() methods will return the Prop3D
	/// and Mapper that the clipping plane belongs to.  The
	/// GetClippingPlaneId() method will return the index of the clipping
	/// plane so that you can retrieve it from the mapper, or -1 if no
	/// clipping plane was picked.
	/// </summary>
	public virtual void PickClippingPlanesOff()
	{
		vtkCellPicker_PickClippingPlanesOff_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellPicker_PickClippingPlanesOn_34(HandleRef pThis);

	/// <summary>
	/// The PickClippingPlanes setting controls how clipping planes are
	/// handled by the pick.  If it is On, then the clipping planes become
	/// pickable objects, even though they are usually invisible.  This
	/// means that if the pick ray intersects a clipping plane before it
	/// hits anything else, the pick will stop at that clipping plane.
	/// The GetProp3D() and GetMapper() methods will return the Prop3D
	/// and Mapper that the clipping plane belongs to.  The
	/// GetClippingPlaneId() method will return the index of the clipping
	/// plane so that you can retrieve it from the mapper, or -1 if no
	/// clipping plane was picked.
	/// </summary>
	public virtual void PickClippingPlanesOn()
	{
		vtkCellPicker_PickClippingPlanesOn_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellPicker_PickTextureDataOff_35(HandleRef pThis);

	/// <summary>
	/// If this is "On" and if the picked prop has a texture, then the data
	/// returned by GetDataSet() will be the texture's data instead of the
	/// mapper's data.  The GetPointId(), GetCellId(), GetPCoords() etc. will
	/// all return information for use with the texture's data.  If the picked
	/// prop does not have any texture, then GetDataSet() will return the
	/// mapper's data instead and GetPointId() etc. will return information
	/// related to the mapper's data.  The default value of PickTextureData
	/// is "Off".
	/// </summary>
	public virtual void PickTextureDataOff()
	{
		vtkCellPicker_PickTextureDataOff_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellPicker_PickTextureDataOn_36(HandleRef pThis);

	/// <summary>
	/// If this is "On" and if the picked prop has a texture, then the data
	/// returned by GetDataSet() will be the texture's data instead of the
	/// mapper's data.  The GetPointId(), GetCellId(), GetPCoords() etc. will
	/// all return information for use with the texture's data.  If the picked
	/// prop does not have any texture, then GetDataSet() will return the
	/// mapper's data instead and GetPointId() etc. will return information
	/// related to the mapper's data.  The default value of PickTextureData
	/// is "Off".
	/// </summary>
	public virtual void PickTextureDataOn()
	{
		vtkCellPicker_PickTextureDataOn_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellPicker_RemoveAllLocators_37(HandleRef pThis);

	/// <summary>
	/// Remove all locators associated with this picker.
	/// </summary>
	public void RemoveAllLocators()
	{
		vtkCellPicker_RemoveAllLocators_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellPicker_RemoveLocator_38(HandleRef pThis, HandleRef locator);

	/// <summary>
	/// Remove a locator that was previously added.  If you try to remove a
	/// nonexistent locator, then nothing will happen and no errors will be
	/// raised.
	/// </summary>
	public void RemoveLocator(vtkAbstractCellLocator locator)
	{
		vtkCellPicker_RemoveLocator_38(GetCppThis(), locator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCellPicker_SafeDownCast_39(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCellPicker SafeDownCast(vtkObjectBase o)
	{
		vtkCellPicker vtkCellPicker2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCellPicker_SafeDownCast_39(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCellPicker2 = (vtkCellPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCellPicker2.Register(null);
			}
		}
		return vtkCellPicker2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellPicker_SetPickClippingPlanes_40(HandleRef pThis, int _arg);

	/// <summary>
	/// The PickClippingPlanes setting controls how clipping planes are
	/// handled by the pick.  If it is On, then the clipping planes become
	/// pickable objects, even though they are usually invisible.  This
	/// means that if the pick ray intersects a clipping plane before it
	/// hits anything else, the pick will stop at that clipping plane.
	/// The GetProp3D() and GetMapper() methods will return the Prop3D
	/// and Mapper that the clipping plane belongs to.  The
	/// GetClippingPlaneId() method will return the index of the clipping
	/// plane so that you can retrieve it from the mapper, or -1 if no
	/// clipping plane was picked.
	/// </summary>
	public virtual void SetPickClippingPlanes(int _arg)
	{
		vtkCellPicker_SetPickClippingPlanes_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellPicker_SetPickTextureData_41(HandleRef pThis, int _arg);

	/// <summary>
	/// If this is "On" and if the picked prop has a texture, then the data
	/// returned by GetDataSet() will be the texture's data instead of the
	/// mapper's data.  The GetPointId(), GetCellId(), GetPCoords() etc. will
	/// all return information for use with the texture's data.  If the picked
	/// prop does not have any texture, then GetDataSet() will return the
	/// mapper's data instead and GetPointId() etc. will return information
	/// related to the mapper's data.  The default value of PickTextureData
	/// is "Off".
	/// </summary>
	public virtual void SetPickTextureData(int _arg)
	{
		vtkCellPicker_SetPickTextureData_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellPicker_SetUseVolumeGradientOpacity_42(HandleRef pThis, int _arg);

	/// <summary>
	/// Use the product of the scalar and gradient opacity functions when
	/// computing the opacity isovalue, instead of just using the scalar
	/// opacity. This parameter is only relevant to volume picking and
	/// is off by default.
	/// </summary>
	public virtual void SetUseVolumeGradientOpacity(int _arg)
	{
		vtkCellPicker_SetUseVolumeGradientOpacity_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellPicker_SetVolumeOpacityIsovalue_43(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the opacity isovalue to use for defining volume surfaces.  The
	/// pick will occur at the location along the pick ray where the
	/// opacity of the volume is equal to this isovalue.  If you want to do
	/// the pick based on an actual data isovalue rather than the opacity,
	/// then pass the data value through the scalar opacity function before
	/// using this method.
	/// </summary>
	public virtual void SetVolumeOpacityIsovalue(double _arg)
	{
		vtkCellPicker_SetVolumeOpacityIsovalue_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellPicker_UseVolumeGradientOpacityOff_44(HandleRef pThis);

	/// <summary>
	/// Use the product of the scalar and gradient opacity functions when
	/// computing the opacity isovalue, instead of just using the scalar
	/// opacity. This parameter is only relevant to volume picking and
	/// is off by default.
	/// </summary>
	public virtual void UseVolumeGradientOpacityOff()
	{
		vtkCellPicker_UseVolumeGradientOpacityOff_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCellPicker_UseVolumeGradientOpacityOn_45(HandleRef pThis);

	/// <summary>
	/// Use the product of the scalar and gradient opacity functions when
	/// computing the opacity isovalue, instead of just using the scalar
	/// opacity. This parameter is only relevant to volume picking and
	/// is off by default.
	/// </summary>
	public virtual void UseVolumeGradientOpacityOn()
	{
		vtkCellPicker_UseVolumeGradientOpacityOn_45(GetCppThis());
	}
}
