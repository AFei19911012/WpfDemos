using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTextureMapToCylinder
/// </summary>
/// <remarks>
///    generate texture coordinates by mapping points to cylinder
///
/// vtkTextureMapToCylinder is a filter that generates 2D texture coordinates
/// by mapping input dataset points onto a cylinder. The cylinder can either be
/// user specified or generated automatically. (The cylinder is generated
/// automatically by computing the axis of the cylinder.)  Note that the
/// generated texture coordinates for the s-coordinate ranges from (0-1)
/// (corresponding to angle of 0-&gt;360 around axis), while the mapping of
/// the t-coordinate is controlled by the projection of points along the axis.
///
/// To specify a cylinder manually, you must provide two points that
/// define the axis of the cylinder. The length of the axis will affect the
/// t-coordinates.
///
/// A special ivar controls how the s-coordinate is generated. If PreventSeam
/// is set to true, the s-texture varies from 0-&gt;1 and then 1-&gt;0 (corresponding
/// to angles of 0-&gt;180 and 180-&gt;360).
///
/// @warning
/// Since the resulting texture s-coordinate will lie between (0,1), and the
/// origin of the texture coordinates is not user-controllable, you may want
/// to use the class vtkTransformTexture to linearly scale and shift the origin
/// of the texture coordinates.
///
/// </remarks>
/// <seealso>
///
/// vtkTextureMapToPlane vtkTextureMapToSphere
/// vtkTransformTexture vtkThresholdTextureCoords
/// </seealso>
public class vtkTextureMapToCylinder : vtkDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTextureMapToCylinder";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTextureMapToCylinder()
	{
		MRClassNameKey = "class vtkTextureMapToCylinder";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextureMapToCylinder"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTextureMapToCylinder(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextureMapToCylinder_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create object with cylinder axis parallel to z-axis (points (0,0,-0.5)
	/// and (0,0,0.5)). The PreventSeam ivar is set to true. The cylinder is
	/// automatically generated.
	/// </summary>
	public new static vtkTextureMapToCylinder New()
	{
		vtkTextureMapToCylinder result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextureMapToCylinder_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTextureMapToCylinder)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Create object with cylinder axis parallel to z-axis (points (0,0,-0.5)
	/// and (0,0,0.5)). The PreventSeam ivar is set to true. The cylinder is
	/// automatically generated.
	/// </summary>
	public vtkTextureMapToCylinder()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTextureMapToCylinder_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToCylinder_AutomaticCylinderGenerationOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off automatic cylinder generation. This means it automatically
	/// finds the cylinder center and axis.
	/// </summary>
	public virtual void AutomaticCylinderGenerationOff()
	{
		vtkTextureMapToCylinder_AutomaticCylinderGenerationOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToCylinder_AutomaticCylinderGenerationOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off automatic cylinder generation. This means it automatically
	/// finds the cylinder center and axis.
	/// </summary>
	public virtual void AutomaticCylinderGenerationOn()
	{
		vtkTextureMapToCylinder_AutomaticCylinderGenerationOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextureMapToCylinder_GetAutomaticCylinderGeneration_03(HandleRef pThis);

	/// <summary>
	/// Turn on/off automatic cylinder generation. This means it automatically
	/// finds the cylinder center and axis.
	/// </summary>
	public virtual int GetAutomaticCylinderGeneration()
	{
		return vtkTextureMapToCylinder_GetAutomaticCylinderGeneration_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTextureMapToCylinder_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTextureMapToCylinder_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTextureMapToCylinder_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTextureMapToCylinder_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextureMapToCylinder_GetPoint1_06(HandleRef pThis);

	/// <summary>
	/// Specify the first point defining the cylinder axis,
	/// </summary>
	public virtual double[] GetPoint1()
	{
		IntPtr intPtr = vtkTextureMapToCylinder_GetPoint1_06(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToCylinder_GetPoint1_07(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify the first point defining the cylinder axis,
	/// </summary>
	public virtual void GetPoint1(IntPtr data)
	{
		vtkTextureMapToCylinder_GetPoint1_07(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextureMapToCylinder_GetPoint2_08(HandleRef pThis);

	/// <summary>
	/// Specify the second point defining the cylinder axis,
	/// </summary>
	public virtual double[] GetPoint2()
	{
		IntPtr intPtr = vtkTextureMapToCylinder_GetPoint2_08(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToCylinder_GetPoint2_09(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify the second point defining the cylinder axis,
	/// </summary>
	public virtual void GetPoint2(IntPtr data)
	{
		vtkTextureMapToCylinder_GetPoint2_09(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextureMapToCylinder_GetPreventSeam_10(HandleRef pThis);

	/// <summary>
	/// Control how the texture coordinates are generated. If PreventSeam is
	/// set, the s-coordinate ranges from 0-&gt;1 and 1-&gt;0 corresponding to the
	/// angle variation from 0-&gt;180 and 180-&gt;0. Otherwise, the s-coordinate
	/// ranges from 0-&gt;1 from 0-&gt;360 degrees.
	/// </summary>
	public virtual int GetPreventSeam()
	{
		return vtkTextureMapToCylinder_GetPreventSeam_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextureMapToCylinder_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTextureMapToCylinder_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextureMapToCylinder_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTextureMapToCylinder_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextureMapToCylinder_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTextureMapToCylinder NewInstance()
	{
		vtkTextureMapToCylinder result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextureMapToCylinder_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTextureMapToCylinder)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToCylinder_PreventSeamOff_15(HandleRef pThis);

	/// <summary>
	/// Control how the texture coordinates are generated. If PreventSeam is
	/// set, the s-coordinate ranges from 0-&gt;1 and 1-&gt;0 corresponding to the
	/// angle variation from 0-&gt;180 and 180-&gt;0. Otherwise, the s-coordinate
	/// ranges from 0-&gt;1 from 0-&gt;360 degrees.
	/// </summary>
	public virtual void PreventSeamOff()
	{
		vtkTextureMapToCylinder_PreventSeamOff_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToCylinder_PreventSeamOn_16(HandleRef pThis);

	/// <summary>
	/// Control how the texture coordinates are generated. If PreventSeam is
	/// set, the s-coordinate ranges from 0-&gt;1 and 1-&gt;0 corresponding to the
	/// angle variation from 0-&gt;180 and 180-&gt;0. Otherwise, the s-coordinate
	/// ranges from 0-&gt;1 from 0-&gt;360 degrees.
	/// </summary>
	public virtual void PreventSeamOn()
	{
		vtkTextureMapToCylinder_PreventSeamOn_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextureMapToCylinder_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTextureMapToCylinder SafeDownCast(vtkObjectBase o)
	{
		vtkTextureMapToCylinder vtkTextureMapToCylinder2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextureMapToCylinder_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTextureMapToCylinder2 = (vtkTextureMapToCylinder)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTextureMapToCylinder2.Register(null);
			}
		}
		return vtkTextureMapToCylinder2;
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToCylinder_SetAutomaticCylinderGeneration_18(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off automatic cylinder generation. This means it automatically
	/// finds the cylinder center and axis.
	/// </summary>
	public virtual void SetAutomaticCylinderGeneration(int _arg)
	{
		vtkTextureMapToCylinder_SetAutomaticCylinderGeneration_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToCylinder_SetPoint1_19(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Specify the first point defining the cylinder axis,
	/// </summary>
	public virtual void SetPoint1(double _arg1, double _arg2, double _arg3)
	{
		vtkTextureMapToCylinder_SetPoint1_19(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToCylinder_SetPoint1_20(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the first point defining the cylinder axis,
	/// </summary>
	public virtual void SetPoint1(IntPtr _arg)
	{
		vtkTextureMapToCylinder_SetPoint1_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToCylinder_SetPoint2_21(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Specify the second point defining the cylinder axis,
	/// </summary>
	public virtual void SetPoint2(double _arg1, double _arg2, double _arg3)
	{
		vtkTextureMapToCylinder_SetPoint2_21(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToCylinder_SetPoint2_22(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the second point defining the cylinder axis,
	/// </summary>
	public virtual void SetPoint2(IntPtr _arg)
	{
		vtkTextureMapToCylinder_SetPoint2_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToCylinder_SetPreventSeam_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Control how the texture coordinates are generated. If PreventSeam is
	/// set, the s-coordinate ranges from 0-&gt;1 and 1-&gt;0 corresponding to the
	/// angle variation from 0-&gt;180 and 180-&gt;0. Otherwise, the s-coordinate
	/// ranges from 0-&gt;1 from 0-&gt;360 degrees.
	/// </summary>
	public virtual void SetPreventSeam(int _arg)
	{
		vtkTextureMapToCylinder_SetPreventSeam_23(GetCppThis(), _arg);
	}
}
