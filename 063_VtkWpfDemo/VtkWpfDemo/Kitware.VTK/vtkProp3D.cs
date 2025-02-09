using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkProp3D
/// </summary>
/// <remarks>
///    represents an 3D object for placement in a rendered scene
///
/// vtkProp3D is an abstract class used to represent an entity in a rendering
/// scene (i.e., vtkProp3D is a vtkProp with an associated transformation
/// matrix).  It handles functions related to the position, orientation and
/// scaling. It combines these instance variables into one 4x4 transformation
/// matrix as follows: [x y z 1] = [x y z 1] Translate(-origin) Scale(scale)
/// Rot(y) Rot(x) Rot (z) Trans(origin) Trans(position). Both vtkActor and
/// vtkVolume are specializations of class vtkProp.  The constructor defaults
/// to: origin(0,0,0) position=(0,0,0) orientation=(0,0,0), no user defined
/// matrix or transform, and no texture map.
///
/// </remarks>
/// <seealso>
///
/// vtkProp vtkActor vtkAssembly vtkVolume
/// </seealso>
public abstract class vtkProp3D : vtkProp
{
	/// <summary>
	/// Specify the coordinate system that this prop is relative to.
	/// This defaults to WORLD but can be set to PHYSICAL which for
	/// VirtualReality is the physical space (aka room) the viewer
	/// is in (in meters). When set to device the CoordinateSystemDevice
	/// is used to place the prop relative to that device (such as a HMD
	/// or controller)
	/// </summary>
	public enum CoordinateSystems
	{
		/// <summary>enum member</summary>
		DEVICE = 2,
		/// <summary>enum member</summary>
		PHYSICAL = 1,
		/// <summary>enum member</summary>
		WORLD = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkProp3D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkProp3D()
	{
		MRClassNameKey = "class vtkProp3D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkProp3D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkProp3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_AddOrientation_01(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Add to the current orientation. See SetOrientation and
	/// GetOrientation for more details. This basically does a
	/// GetOrientation, adds the passed in arguments, and then calls
	/// SetOrientation.
	/// </summary>
	public void AddOrientation(double x, double y, double z)
	{
		vtkProp3D_AddOrientation_01(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_AddOrientation_02(HandleRef pThis, IntPtr orentation);

	/// <summary>
	/// Add to the current orientation. See SetOrientation and
	/// GetOrientation for more details. This basically does a
	/// GetOrientation, adds the passed in arguments, and then calls
	/// SetOrientation.
	/// </summary>
	public void AddOrientation(IntPtr orentation)
	{
		vtkProp3D_AddOrientation_02(GetCppThis(), orentation);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_AddPosition_03(HandleRef pThis, IntPtr deltaPosition);

	/// <summary>
	/// Set/Get/Add the position of the Prop3D in world coordinates.
	/// </summary>
	public void AddPosition(IntPtr deltaPosition)
	{
		vtkProp3D_AddPosition_03(GetCppThis(), deltaPosition);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_AddPosition_04(HandleRef pThis, double deltaX, double deltaY, double deltaZ);

	/// <summary>
	/// Set/Get/Add the position of the Prop3D in world coordinates.
	/// </summary>
	public void AddPosition(double deltaX, double deltaY, double deltaZ)
	{
		vtkProp3D_AddPosition_04(GetCppThis(), deltaX, deltaY, deltaZ);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_ComputeMatrix_05(HandleRef pThis);

	/// <summary>
	/// Generate the matrix based on ivars
	/// </summary>
	public virtual void ComputeMatrix()
	{
		vtkProp3D_ComputeMatrix_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_GetBounds_06(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Get the bounds for this Prop3D as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax).
	/// </summary>
	public void GetBounds(IntPtr bounds)
	{
		vtkProp3D_GetBounds_06(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp3D_GetBounds_07(HandleRef pThis);

	/// <summary>
	/// Get the bounds for this Prop3D as (Xmin,Xmax,Ymin,Ymax,Zmin,Zmax).
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkProp3D_GetBounds_07(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp3D_GetCenter_08(HandleRef pThis);

	/// <summary>
	/// Get the center of the bounding box in world coordinates.
	/// </summary>
	public double[] GetCenter()
	{
		IntPtr intPtr = vtkProp3D_GetCenter_08(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern CoordinateSystems vtkProp3D_GetCoordinateSystem_09(HandleRef pThis);

	/// <summary>
	/// Specify the coordinate system that this prop is relative to.
	/// This defaults to WORLD but can be set to PHYSICAL which for
	/// VirtualReality is the physical space (aka room) the viewer
	/// is in (in meters). When set to device the CoordinateSystemDevice
	/// is used to place the prop relative to that device (such as a HMD
	/// or controller)
	/// </summary>
	public virtual CoordinateSystems GetCoordinateSystem()
	{
		return vtkProp3D_GetCoordinateSystem_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp3D_GetCoordinateSystemAsString_10(HandleRef pThis);

	/// <summary>
	/// Specify the coordinate system that this prop is relative to.
	/// This defaults to WORLD but can be set to PHYSICAL which for
	/// VirtualReality is the physical space (aka room) the viewer
	/// is in (in meters). When set to device the CoordinateSystemDevice
	/// is used to place the prop relative to that device (such as a HMD
	/// or controller)
	/// </summary>
	public string GetCoordinateSystemAsString()
	{
		return Marshal.PtrToStringAnsi(vtkProp3D_GetCoordinateSystemAsString_10(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp3D_GetCoordinateSystemDevice_11(HandleRef pThis);

	/// <summary>
	/// Specify the device to be used when the coordinate system is set
	/// to DEVICE. Defaults to vtkEventDataDevice::HeadMountedDisplay.
	/// </summary>
	public virtual int GetCoordinateSystemDevice()
	{
		return vtkProp3D_GetCoordinateSystemDevice_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp3D_GetCoordinateSystemRenderer_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the Renderer that the prop3d is relative to when the
	/// coordinate system is set to PHYSICAL or DEVICE
	/// </summary>
	public vtkRenderer GetCoordinateSystemRenderer()
	{
		vtkRenderer vtkRenderer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProp3D_GetCoordinateSystemRenderer_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderer2 = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderer2.Register(null);
			}
		}
		return vtkRenderer2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp3D_GetIsIdentity_13(HandleRef pThis);

	/// <summary>
	/// Is the matrix for this actor identity
	/// </summary>
	public virtual int GetIsIdentity()
	{
		return vtkProp3D_GetIsIdentity_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProp3D_GetLength_14(HandleRef pThis);

	/// <summary>
	/// Get the length of the diagonal of the bounding box.
	/// </summary>
	public double GetLength()
	{
		return vtkProp3D_GetLength_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkProp3D_GetMTime_15(HandleRef pThis);

	/// <summary>
	/// Get the vtkProp3D's mtime
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkProp3D_GetMTime_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_GetMatrix_16(HandleRef pThis, HandleRef result);

	/// <summary>
	/// Return a reference to the Prop3D's 4x4 composite matrix.
	/// Get the matrix from the position, origin, scale and orientation This
	/// matrix is cached, so multiple GetMatrix() calls will be efficient.
	/// </summary>
	public virtual void GetMatrix(vtkMatrix4x4 result)
	{
		vtkProp3D_GetMatrix_16(GetCppThis(), result?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_GetMatrix_17(HandleRef pThis, IntPtr result);

	/// <summary>
	/// Return a reference to the Prop3D's 4x4 composite matrix.
	/// Get the matrix from the position, origin, scale and orientation This
	/// matrix is cached, so multiple GetMatrix() calls will be efficient.
	/// </summary>
	public virtual void GetMatrix(IntPtr result)
	{
		vtkProp3D_GetMatrix_17(GetCppThis(), result);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp3D_GetMatrix_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get a pointer to an internal vtkMatrix4x4. that represents
	/// </summary>
	public override vtkMatrix4x4 GetMatrix()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProp3D_GetMatrix_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMatrix4x5 = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMatrix4x5.Register(null);
			}
		}
		return vtkMatrix4x5;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_GetModelToWorldMatrix_19(HandleRef pThis, HandleRef result);

	/// <summary>
	/// Return a reference to the Prop3D's Model to World matrix.
	/// This method takes into account the coordinate system the prop is in.
	/// </summary>
	public virtual void GetModelToWorldMatrix(vtkMatrix4x4 result)
	{
		vtkProp3D_GetModelToWorldMatrix_19(GetCppThis(), result?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProp3D_GetNumberOfGenerationsFromBase_20(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkProp3D_GetNumberOfGenerationsFromBase_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProp3D_GetNumberOfGenerationsFromBaseType_21(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkProp3D_GetNumberOfGenerationsFromBaseType_21(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp3D_GetOrientation_22(HandleRef pThis);

	/// <summary>
	/// Returns the orientation of the Prop3D as s vector of X,Y and Z rotation.
	/// The ordering in which these rotations must be done to generate the
	/// same matrix is RotateZ, RotateX, and finally RotateY. See also
	/// SetOrientation.
	/// </summary>
	public double[] GetOrientation()
	{
		IntPtr intPtr = vtkProp3D_GetOrientation_22(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_GetOrientation_23(HandleRef pThis, IntPtr orentation);

	/// <summary>
	/// Returns the orientation of the Prop3D as s vector of X,Y and Z rotation.
	/// The ordering in which these rotations must be done to generate the
	/// same matrix is RotateZ, RotateX, and finally RotateY. See also
	/// SetOrientation.
	/// </summary>
	public void GetOrientation(IntPtr orentation)
	{
		vtkProp3D_GetOrientation_23(GetCppThis(), orentation);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp3D_GetOrientationWXYZ_24(HandleRef pThis);

	/// <summary>
	/// Returns the WXYZ orientation of the Prop3D.
	/// </summary>
	public double[] GetOrientationWXYZ()
	{
		IntPtr intPtr = vtkProp3D_GetOrientationWXYZ_24(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp3D_GetOrigin_25(HandleRef pThis);

	/// <summary>
	/// Set/Get the origin of the Prop3D. This is the point about which all
	/// rotations take place.
	/// </summary>
	public virtual double[] GetOrigin()
	{
		IntPtr intPtr = vtkProp3D_GetOrigin_25(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_GetOrigin_26(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the origin of the Prop3D. This is the point about which all
	/// rotations take place.
	/// </summary>
	public virtual void GetOrigin(IntPtr data)
	{
		vtkProp3D_GetOrigin_26(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp3D_GetPosition_27(HandleRef pThis);

	/// <summary>
	/// Set/Get/Add the position of the Prop3D in world coordinates.
	/// </summary>
	public virtual double[] GetPosition()
	{
		IntPtr intPtr = vtkProp3D_GetPosition_27(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_GetPosition_28(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get/Add the position of the Prop3D in world coordinates.
	/// </summary>
	public virtual void GetPosition(IntPtr data)
	{
		vtkProp3D_GetPosition_28(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp3D_GetScale_29(HandleRef pThis);

	/// <summary>
	/// Set/Get the scale of the actor. Scaling in performed independently on the
	/// X, Y and Z axis. A scale of zero is illegal and will be replaced with one.
	/// </summary>
	public virtual double[] GetScale()
	{
		IntPtr intPtr = vtkProp3D_GetScale_29(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_GetScale_30(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the scale of the actor. Scaling in performed independently on the
	/// X, Y and Z axis. A scale of zero is illegal and will be replaced with one.
	/// </summary>
	public virtual void GetScale(IntPtr data)
	{
		vtkProp3D_GetScale_30(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp3D_GetUserMatrix_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The UserMatrix can be used in place of UserTransform.
	/// </summary>
	public vtkMatrix4x4 GetUserMatrix()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProp3D_GetUserMatrix_31(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMatrix4x5 = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMatrix4x5.Register(null);
			}
		}
		return vtkMatrix4x5;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp3D_GetUserTransform_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// In addition to the instance variables such as position and orientation,
	/// you can add an additional transformation for your own use.  This
	/// transformation is concatenated with the actor's internal transformation,
	/// which you implicitly create through the use of SetPosition(),
	/// SetOrigin() and SetOrientation().
	/// &lt;p&gt;If the internal transformation
	/// is identity (i.e. if you don't set the Position, Origin, or
	/// Orientation) then the actors final transformation will be the
	/// UserTransform, concatenated with the UserMatrix if the UserMatrix
	/// is present.
	/// </summary>
	public virtual vtkLinearTransform GetUserTransform()
	{
		vtkLinearTransform vtkLinearTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProp3D_GetUserTransform_32(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLinearTransform2 = (vtkLinearTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLinearTransform2.Register(null);
			}
		}
		return vtkLinearTransform2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkProp3D_GetUserTransformMatrixMTime_33(HandleRef pThis);

	/// <summary>
	/// Get the modified time of the user matrix or user transform.
	/// </summary>
	public ulong GetUserTransformMatrixMTime()
	{
		return vtkProp3D_GetUserTransformMatrixMTime_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp3D_GetXRange_34(HandleRef pThis);

	/// <summary>
	/// Get the Prop3D's x range in world coordinates.
	/// </summary>
	public double[] GetXRange()
	{
		IntPtr intPtr = vtkProp3D_GetXRange_34(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp3D_GetYRange_35(HandleRef pThis);

	/// <summary>
	/// Get the Prop3D's y range in world coordinates.
	/// </summary>
	public double[] GetYRange()
	{
		IntPtr intPtr = vtkProp3D_GetYRange_35(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp3D_GetZRange_36(HandleRef pThis);

	/// <summary>
	/// Get the Prop3D's z range in world coordinates.
	/// </summary>
	public double[] GetZRange()
	{
		IntPtr intPtr = vtkProp3D_GetZRange_36(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_InitPathTraversal_37(HandleRef pThis);

	/// <summary>
	/// Overload vtkProp's method for setting up assembly paths. See
	/// the documentation for vtkProp.
	/// </summary>
	public override void InitPathTraversal()
	{
		vtkProp3D_InitPathTraversal_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp3D_IsA_38(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkProp3D_IsA_38(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProp3D_IsTypeOf_39(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkProp3D_IsTypeOf_39(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp3D_NewInstance_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkProp3D NewInstance()
	{
		vtkProp3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProp3D_NewInstance_40(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProp3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_PokeMatrix_41(HandleRef pThis, HandleRef matrix);

	/// <summary>
	/// This method modifies the vtkProp3D so that its transformation
	/// state is set to the matrix specified. The method does this by
	/// setting appropriate transformation-related ivars to initial
	/// values (i.e., not transformed), and placing the user-supplied
	/// matrix into the UserMatrix of this vtkProp3D. If the method is
	/// called again with a NULL matrix, then the original state of the
	/// vtkProp3D will be restored. This method is used to support
	/// picking and assembly structures.
	/// </summary>
	public override void PokeMatrix(vtkMatrix4x4 matrix)
	{
		vtkProp3D_PokeMatrix_41(GetCppThis(), matrix?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_RotateWXYZ_42(HandleRef pThis, double w, double x, double y, double z);

	/// <summary>
	/// Rotate the Prop3D in degrees about an arbitrary axis specified by
	/// the last three arguments. The axis is specified in world
	/// coordinates. To rotate an about its model axes, use RotateX,
	/// RotateY, RotateZ.
	/// </summary>
	public void RotateWXYZ(double w, double x, double y, double z)
	{
		vtkProp3D_RotateWXYZ_42(GetCppThis(), w, x, y, z);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_RotateX_43(HandleRef pThis, double arg0);

	/// <summary>
	/// Rotate the Prop3D in degrees about the X axis using the right hand
	/// rule. The axis is the Prop3D's X axis, which can change as other
	/// rotations are performed.  To rotate about the world X axis use
	/// RotateWXYZ (angle, 1, 0, 0). This rotation is applied before all
	/// others in the current transformation matrix.
	/// </summary>
	public void RotateX(double arg0)
	{
		vtkProp3D_RotateX_43(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_RotateY_44(HandleRef pThis, double arg0);

	/// <summary>
	/// Rotate the Prop3D in degrees about the Y axis using the right hand
	/// rule. The axis is the Prop3D's Y axis, which can change as other
	/// rotations are performed.  To rotate about the world Y axis use
	/// RotateWXYZ (angle, 0, 1, 0). This rotation is applied before all
	/// others in the current transformation matrix.
	/// </summary>
	public void RotateY(double arg0)
	{
		vtkProp3D_RotateY_44(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_RotateZ_45(HandleRef pThis, double arg0);

	/// <summary>
	/// Rotate the Prop3D in degrees about the Z axis using the right hand
	/// rule. The axis is the Prop3D's Z axis, which can change as other
	/// rotations are performed.  To rotate about the world Z axis use
	/// RotateWXYZ (angle, 0, 0, 1). This rotation is applied before all
	/// others in the current transformation matrix.
	/// </summary>
	public void RotateZ(double arg0)
	{
		vtkProp3D_RotateZ_45(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProp3D_SafeDownCast_46(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkProp3D SafeDownCast(vtkObjectBase o)
	{
		vtkProp3D vtkProp3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProp3D_SafeDownCast_46(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProp3D2 = (vtkProp3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProp3D2.Register(null);
			}
		}
		return vtkProp3D2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_SetCoordinateSystem_47(HandleRef pThis, CoordinateSystems val);

	/// <summary>
	/// Specify the coordinate system that this prop is relative to.
	/// This defaults to WORLD but can be set to PHYSICAL which for
	/// VirtualReality is the physical space (aka room) the viewer
	/// is in (in meters). When set to device the CoordinateSystemDevice
	/// is used to place the prop relative to that device (such as a HMD
	/// or controller)
	/// </summary>
	public void SetCoordinateSystem(CoordinateSystems val)
	{
		vtkProp3D_SetCoordinateSystem_47(GetCppThis(), val);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_SetCoordinateSystemDevice_48(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the device to be used when the coordinate system is set
	/// to DEVICE. Defaults to vtkEventDataDevice::HeadMountedDisplay.
	/// </summary>
	public virtual void SetCoordinateSystemDevice(int _arg)
	{
		vtkProp3D_SetCoordinateSystemDevice_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_SetCoordinateSystemRenderer_49(HandleRef pThis, HandleRef ren);

	/// <summary>
	/// Specify the Renderer that the prop3d is relative to when the
	/// coordinate system is set to PHYSICAL or DEVICE
	/// </summary>
	public void SetCoordinateSystemRenderer(vtkRenderer ren)
	{
		vtkProp3D_SetCoordinateSystemRenderer_49(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_SetCoordinateSystemToDevice_50(HandleRef pThis);

	/// <summary>
	/// Specify the coordinate system that this prop is relative to.
	/// This defaults to WORLD but can be set to PHYSICAL which for
	/// VirtualReality is the physical space (aka room) the viewer
	/// is in (in meters). When set to device the CoordinateSystemDevice
	/// is used to place the prop relative to that device (such as a HMD
	/// or controller)
	/// </summary>
	public void SetCoordinateSystemToDevice()
	{
		vtkProp3D_SetCoordinateSystemToDevice_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_SetCoordinateSystemToPhysical_51(HandleRef pThis);

	/// <summary>
	/// Specify the coordinate system that this prop is relative to.
	/// This defaults to WORLD but can be set to PHYSICAL which for
	/// VirtualReality is the physical space (aka room) the viewer
	/// is in (in meters). When set to device the CoordinateSystemDevice
	/// is used to place the prop relative to that device (such as a HMD
	/// or controller)
	/// </summary>
	public void SetCoordinateSystemToPhysical()
	{
		vtkProp3D_SetCoordinateSystemToPhysical_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_SetCoordinateSystemToWorld_52(HandleRef pThis);

	/// <summary>
	/// Specify the coordinate system that this prop is relative to.
	/// This defaults to WORLD but can be set to PHYSICAL which for
	/// VirtualReality is the physical space (aka room) the viewer
	/// is in (in meters). When set to device the CoordinateSystemDevice
	/// is used to place the prop relative to that device (such as a HMD
	/// or controller)
	/// </summary>
	public void SetCoordinateSystemToWorld()
	{
		vtkProp3D_SetCoordinateSystemToWorld_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_SetOrientation_53(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Sets the orientation of the Prop3D.  Orientation is specified as
	/// X,Y and Z rotations in that order, but they are performed as
	/// RotateZ, RotateX, and finally RotateY.
	/// </summary>
	public void SetOrientation(double x, double y, double z)
	{
		vtkProp3D_SetOrientation_53(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_SetOrientation_54(HandleRef pThis, IntPtr orientation);

	/// <summary>
	/// Sets the orientation of the Prop3D.  Orientation is specified as
	/// X,Y and Z rotations in that order, but they are performed as
	/// RotateZ, RotateX, and finally RotateY.
	/// </summary>
	public void SetOrientation(IntPtr orientation)
	{
		vtkProp3D_SetOrientation_54(GetCppThis(), orientation);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_SetOrigin_55(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set/Get the origin of the Prop3D. This is the point about which all
	/// rotations take place.
	/// </summary>
	public virtual void SetOrigin(double x, double y, double z)
	{
		vtkProp3D_SetOrigin_55(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_SetOrigin_56(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Set/Get the origin of the Prop3D. This is the point about which all
	/// rotations take place.
	/// </summary>
	public virtual void SetOrigin(IntPtr pos)
	{
		vtkProp3D_SetOrigin_56(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_SetPosition_57(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set/Get/Add the position of the Prop3D in world coordinates.
	/// </summary>
	public virtual void SetPosition(double x, double y, double z)
	{
		vtkProp3D_SetPosition_57(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_SetPosition_58(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Set/Get/Add the position of the Prop3D in world coordinates.
	/// </summary>
	public virtual void SetPosition(IntPtr pos)
	{
		vtkProp3D_SetPosition_58(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_SetPropertiesFromModelToWorldMatrix_59(HandleRef pThis, HandleRef modelToWorld);

	/// <summary>
	/// Set the position, scale, orientation from a provided model to world matrix.
	/// If the prop is in a coordinate system other than world, then ren must be non-null
	/// </summary>
	public virtual void SetPropertiesFromModelToWorldMatrix(vtkMatrix4x4 modelToWorld)
	{
		vtkProp3D_SetPropertiesFromModelToWorldMatrix_59(GetCppThis(), modelToWorld?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_SetScale_60(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set/Get the scale of the actor. Scaling in performed independently on the
	/// X, Y and Z axis. A scale of zero is illegal and will be replaced with one.
	/// </summary>
	public virtual void SetScale(double x, double y, double z)
	{
		vtkProp3D_SetScale_60(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_SetScale_61(HandleRef pThis, IntPtr scale);

	/// <summary>
	/// Set/Get the scale of the actor. Scaling in performed independently on the
	/// X, Y and Z axis. A scale of zero is illegal and will be replaced with one.
	/// </summary>
	public virtual void SetScale(IntPtr scale)
	{
		vtkProp3D_SetScale_61(GetCppThis(), scale);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_SetScale_62(HandleRef pThis, double s);

	/// <summary>
	/// Method to set the scale isotropically
	/// </summary>
	public void SetScale(double s)
	{
		vtkProp3D_SetScale_62(GetCppThis(), s);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_SetUserMatrix_63(HandleRef pThis, HandleRef matrix);

	/// <summary>
	/// The UserMatrix can be used in place of UserTransform.
	/// </summary>
	public void SetUserMatrix(vtkMatrix4x4 matrix)
	{
		vtkProp3D_SetUserMatrix_63(GetCppThis(), matrix?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_SetUserTransform_64(HandleRef pThis, HandleRef transform);

	/// <summary>
	/// In addition to the instance variables such as position and orientation,
	/// you can add an additional transformation for your own use.  This
	/// transformation is concatenated with the actor's internal transformation,
	/// which you implicitly create through the use of SetPosition(),
	/// SetOrigin() and SetOrientation().
	/// &lt;p&gt;If the internal transformation
	/// is identity (i.e. if you don't set the Position, Origin, or
	/// Orientation) then the actors final transformation will be the
	/// UserTransform, concatenated with the UserMatrix if the UserMatrix
	/// is present.
	/// </summary>
	public void SetUserTransform(vtkLinearTransform transform)
	{
		vtkProp3D_SetUserTransform_64(GetCppThis(), transform?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProp3D_ShallowCopy_65(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Shallow copy of this vtkProp3D.
	/// </summary>
	public override void ShallowCopy(vtkProp prop)
	{
		vtkProp3D_ShallowCopy_65(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}
}
