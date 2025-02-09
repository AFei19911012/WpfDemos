using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTextureMapToSphere
/// </summary>
/// <remarks>
///    generate texture coordinates by mapping points to sphere
///
/// vtkTextureMapToSphere is a filter that generates 2D texture coordinates by
/// mapping input dataset points onto a sphere. The sphere can either be user
/// specified or generated automatically. (The sphere is generated
/// automatically by computing the center (i.e., averaged coordinates) of the
/// sphere.)  Note that the generated texture coordinates range between
/// (0,1). The s-coordinate lies in the angular direction around the z-axis,
/// measured counter-clockwise from the x-axis. The t-coordinate lies in the
/// angular direction measured down from the north pole towards the south
/// pole.
///
/// A special ivar controls how the s-coordinate is generated. If PreventSeam
/// is set to true, the s-texture varies from 0-&gt;1 and then 1-&gt;0 (corresponding
/// to angles of 0-&gt;180 and 180-&gt;360).
///
/// @warning
/// The resulting texture coordinates will lie between (0,1), and the texture
/// coordinates are determined with respect to the modeler's x-y-z coordinate
/// system. Use the class vtkTransformTextureCoords to linearly scale and
/// shift the origin of the texture coordinates (if necessary).
///
/// </remarks>
/// <seealso>
///
/// vtkTextureMapToPlane vtkTextureMapToCylinder
/// vtkTransformTexture vtkThresholdTextureCoords
/// </seealso>
public class vtkTextureMapToSphere : vtkDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTextureMapToSphere";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTextureMapToSphere()
	{
		MRClassNameKey = "class vtkTextureMapToSphere";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextureMapToSphere"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTextureMapToSphere(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextureMapToSphere_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create object with Center (0,0,0) and the PreventSeam ivar is set to
	/// true. The sphere center is automatically computed.
	/// </summary>
	public new static vtkTextureMapToSphere New()
	{
		vtkTextureMapToSphere result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextureMapToSphere_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTextureMapToSphere)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Create object with Center (0,0,0) and the PreventSeam ivar is set to
	/// true. The sphere center is automatically computed.
	/// </summary>
	public vtkTextureMapToSphere()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTextureMapToSphere_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkTextureMapToSphere_AutomaticSphereGenerationOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off automatic sphere generation. This means it automatically
	/// finds the sphere center.
	/// </summary>
	public virtual void AutomaticSphereGenerationOff()
	{
		vtkTextureMapToSphere_AutomaticSphereGenerationOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToSphere_AutomaticSphereGenerationOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off automatic sphere generation. This means it automatically
	/// finds the sphere center.
	/// </summary>
	public virtual void AutomaticSphereGenerationOn()
	{
		vtkTextureMapToSphere_AutomaticSphereGenerationOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToSphere_ComputeCenter_03(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Control how the texture coordinates are generated. If PreventSeam is
	/// set, the s-coordinate ranges from 0-&gt;1 and 1-&gt;0 corresponding to the
	/// theta angle variation between 0-&gt;180 and 180-&gt;0 degrees. Otherwise, the
	/// s-coordinate ranges from 0-&gt;1 between 0-&gt;360 degrees.
	/// </summary>
	public virtual void ComputeCenter(vtkDataSet input)
	{
		vtkTextureMapToSphere_ComputeCenter_03(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextureMapToSphere_GetAutomaticSphereGeneration_04(HandleRef pThis);

	/// <summary>
	/// Turn on/off automatic sphere generation. This means it automatically
	/// finds the sphere center.
	/// </summary>
	public virtual int GetAutomaticSphereGeneration()
	{
		return vtkTextureMapToSphere_GetAutomaticSphereGeneration_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextureMapToSphere_GetCenter_05(HandleRef pThis);

	/// <summary>
	/// Specify a point defining the center of the sphere.
	/// </summary>
	public virtual double[] GetCenter()
	{
		IntPtr intPtr = vtkTextureMapToSphere_GetCenter_05(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToSphere_GetCenter_06(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify a point defining the center of the sphere.
	/// </summary>
	public virtual void GetCenter(IntPtr data)
	{
		vtkTextureMapToSphere_GetCenter_06(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTextureMapToSphere_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTextureMapToSphere_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTextureMapToSphere_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTextureMapToSphere_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextureMapToSphere_GetPreventSeam_09(HandleRef pThis);

	/// <summary>
	/// Control how the texture coordinates are generated. If PreventSeam is
	/// set, the s-coordinate ranges from 0-&gt;1 and 1-&gt;0 corresponding to the
	/// theta angle variation between 0-&gt;180 and 180-&gt;0 degrees. Otherwise, the
	/// s-coordinate ranges from 0-&gt;1 between 0-&gt;360 degrees.
	/// </summary>
	public virtual int GetPreventSeam()
	{
		return vtkTextureMapToSphere_GetPreventSeam_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextureMapToSphere_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTextureMapToSphere_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextureMapToSphere_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTextureMapToSphere_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextureMapToSphere_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTextureMapToSphere NewInstance()
	{
		vtkTextureMapToSphere result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextureMapToSphere_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTextureMapToSphere)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToSphere_PreventSeamOff_14(HandleRef pThis);

	/// <summary>
	/// Control how the texture coordinates are generated. If PreventSeam is
	/// set, the s-coordinate ranges from 0-&gt;1 and 1-&gt;0 corresponding to the
	/// theta angle variation between 0-&gt;180 and 180-&gt;0 degrees. Otherwise, the
	/// s-coordinate ranges from 0-&gt;1 between 0-&gt;360 degrees.
	/// </summary>
	public virtual void PreventSeamOff()
	{
		vtkTextureMapToSphere_PreventSeamOff_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToSphere_PreventSeamOn_15(HandleRef pThis);

	/// <summary>
	/// Control how the texture coordinates are generated. If PreventSeam is
	/// set, the s-coordinate ranges from 0-&gt;1 and 1-&gt;0 corresponding to the
	/// theta angle variation between 0-&gt;180 and 180-&gt;0 degrees. Otherwise, the
	/// s-coordinate ranges from 0-&gt;1 between 0-&gt;360 degrees.
	/// </summary>
	public virtual void PreventSeamOn()
	{
		vtkTextureMapToSphere_PreventSeamOn_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextureMapToSphere_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTextureMapToSphere SafeDownCast(vtkObjectBase o)
	{
		vtkTextureMapToSphere vtkTextureMapToSphere2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextureMapToSphere_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTextureMapToSphere2 = (vtkTextureMapToSphere)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTextureMapToSphere2.Register(null);
			}
		}
		return vtkTextureMapToSphere2;
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToSphere_SetAutomaticSphereGeneration_17(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off automatic sphere generation. This means it automatically
	/// finds the sphere center.
	/// </summary>
	public virtual void SetAutomaticSphereGeneration(int _arg)
	{
		vtkTextureMapToSphere_SetAutomaticSphereGeneration_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToSphere_SetCenter_18(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Specify a point defining the center of the sphere.
	/// </summary>
	public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
	{
		vtkTextureMapToSphere_SetCenter_18(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToSphere_SetCenter_19(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify a point defining the center of the sphere.
	/// </summary>
	public virtual void SetCenter(IntPtr _arg)
	{
		vtkTextureMapToSphere_SetCenter_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToSphere_SetPreventSeam_20(HandleRef pThis, int _arg);

	/// <summary>
	/// Control how the texture coordinates are generated. If PreventSeam is
	/// set, the s-coordinate ranges from 0-&gt;1 and 1-&gt;0 corresponding to the
	/// theta angle variation between 0-&gt;180 and 180-&gt;0 degrees. Otherwise, the
	/// s-coordinate ranges from 0-&gt;1 between 0-&gt;360 degrees.
	/// </summary>
	public virtual void SetPreventSeam(int _arg)
	{
		vtkTextureMapToSphere_SetPreventSeam_20(GetCppThis(), _arg);
	}
}
