using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTextureMapToPlane
/// </summary>
/// <remarks>
///    generate texture coordinates by mapping points to plane
///
/// vtkTextureMapToPlane is a filter that generates 2D texture coordinates
/// by mapping input dataset points onto a plane. The plane can either be
/// user specified or generated automatically. (A least squares method is
/// used to generate the plane automatically.)
///
/// There are two ways you can specify the plane. The first is to provide a
/// plane normal. In this case the points are projected to a plane, and the
/// points are then mapped into the user specified s-t coordinate range. For
/// more control, you can specify a plane with three points: an origin and two
/// points defining the two axes of the plane. (This is compatible with the
/// vtkPlaneSource.) Using the second method, the SRange and TRange vectors
/// are ignored, since the presumption is that the user does not want to scale
/// the texture coordinates; and you can adjust the origin and axes points to
/// achieve the texture coordinate scaling you need. Note also that using the
/// three point method the axes do not have to be orthogonal.
///
/// </remarks>
/// <seealso>
///
///  vtkPlaneSource vtkTextureMapToCylinder
/// vtkTextureMapToSphere vtkThresholdTextureCoords
/// </seealso>
public class vtkTextureMapToPlane : vtkDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTextureMapToPlane";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTextureMapToPlane()
	{
		MRClassNameKey = "class vtkTextureMapToPlane";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextureMapToPlane"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTextureMapToPlane(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextureMapToPlane_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct with s,t range=(0,1) and automatic plane generation turned on.
	/// </summary>
	public new static vtkTextureMapToPlane New()
	{
		vtkTextureMapToPlane result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextureMapToPlane_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTextureMapToPlane)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct with s,t range=(0,1) and automatic plane generation turned on.
	/// </summary>
	public vtkTextureMapToPlane()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTextureMapToPlane_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkTextureMapToPlane_AutomaticPlaneGenerationOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off automatic plane generation.
	/// </summary>
	public virtual void AutomaticPlaneGenerationOff()
	{
		vtkTextureMapToPlane_AutomaticPlaneGenerationOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToPlane_AutomaticPlaneGenerationOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off automatic plane generation.
	/// </summary>
	public virtual void AutomaticPlaneGenerationOn()
	{
		vtkTextureMapToPlane_AutomaticPlaneGenerationOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextureMapToPlane_GetAutomaticPlaneGeneration_03(HandleRef pThis);

	/// <summary>
	/// Turn on/off automatic plane generation.
	/// </summary>
	public virtual int GetAutomaticPlaneGeneration()
	{
		return vtkTextureMapToPlane_GetAutomaticPlaneGeneration_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextureMapToPlane_GetNormal_04(HandleRef pThis);

	/// <summary>
	/// Specify plane normal. An alternative way to specify a map plane. Using
	/// this method, the object will scale the resulting texture coordinate
	/// between the SRange and TRange specified.
	/// </summary>
	public virtual double[] GetNormal()
	{
		IntPtr intPtr = vtkTextureMapToPlane_GetNormal_04(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToPlane_GetNormal_05(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify plane normal. An alternative way to specify a map plane. Using
	/// this method, the object will scale the resulting texture coordinate
	/// between the SRange and TRange specified.
	/// </summary>
	public virtual void GetNormal(IntPtr data)
	{
		vtkTextureMapToPlane_GetNormal_05(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTextureMapToPlane_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTextureMapToPlane_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTextureMapToPlane_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTextureMapToPlane_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextureMapToPlane_GetOrigin_08(HandleRef pThis);

	/// <summary>
	/// Specify a point defining the origin of the plane. Used in conjunction with
	/// the Point1 and Point2 ivars to specify a map plane.
	/// </summary>
	public virtual double[] GetOrigin()
	{
		IntPtr intPtr = vtkTextureMapToPlane_GetOrigin_08(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToPlane_GetOrigin_09(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify a point defining the origin of the plane. Used in conjunction with
	/// the Point1 and Point2 ivars to specify a map plane.
	/// </summary>
	public virtual void GetOrigin(IntPtr data)
	{
		vtkTextureMapToPlane_GetOrigin_09(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextureMapToPlane_GetPoint1_10(HandleRef pThis);

	/// <summary>
	/// Specify a point defining the first axis of the plane.
	/// </summary>
	public virtual double[] GetPoint1()
	{
		IntPtr intPtr = vtkTextureMapToPlane_GetPoint1_10(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToPlane_GetPoint1_11(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify a point defining the first axis of the plane.
	/// </summary>
	public virtual void GetPoint1(IntPtr data)
	{
		vtkTextureMapToPlane_GetPoint1_11(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextureMapToPlane_GetPoint2_12(HandleRef pThis);

	/// <summary>
	/// Specify a point defining the second axis of the plane.
	/// </summary>
	public virtual double[] GetPoint2()
	{
		IntPtr intPtr = vtkTextureMapToPlane_GetPoint2_12(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToPlane_GetPoint2_13(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify a point defining the second axis of the plane.
	/// </summary>
	public virtual void GetPoint2(IntPtr data)
	{
		vtkTextureMapToPlane_GetPoint2_13(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextureMapToPlane_GetSRange_14(HandleRef pThis);

	/// <summary>
	/// Specify s-coordinate range for texture s-t coordinate pair.
	/// </summary>
	public virtual double[] GetSRange()
	{
		IntPtr intPtr = vtkTextureMapToPlane_GetSRange_14(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToPlane_GetSRange_15(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify s-coordinate range for texture s-t coordinate pair.
	/// </summary>
	public virtual void GetSRange(IntPtr data)
	{
		vtkTextureMapToPlane_GetSRange_15(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextureMapToPlane_GetTRange_16(HandleRef pThis);

	/// <summary>
	/// Specify t-coordinate range for texture s-t coordinate pair.
	/// </summary>
	public virtual double[] GetTRange()
	{
		IntPtr intPtr = vtkTextureMapToPlane_GetTRange_16(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToPlane_GetTRange_17(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify t-coordinate range for texture s-t coordinate pair.
	/// </summary>
	public virtual void GetTRange(IntPtr data)
	{
		vtkTextureMapToPlane_GetTRange_17(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextureMapToPlane_IsA_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTextureMapToPlane_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextureMapToPlane_IsTypeOf_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTextureMapToPlane_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextureMapToPlane_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTextureMapToPlane NewInstance()
	{
		vtkTextureMapToPlane result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextureMapToPlane_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTextureMapToPlane)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextureMapToPlane_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTextureMapToPlane SafeDownCast(vtkObjectBase o)
	{
		vtkTextureMapToPlane vtkTextureMapToPlane2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextureMapToPlane_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTextureMapToPlane2 = (vtkTextureMapToPlane)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTextureMapToPlane2.Register(null);
			}
		}
		return vtkTextureMapToPlane2;
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToPlane_SetAutomaticPlaneGeneration_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off automatic plane generation.
	/// </summary>
	public virtual void SetAutomaticPlaneGeneration(int _arg)
	{
		vtkTextureMapToPlane_SetAutomaticPlaneGeneration_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToPlane_SetNormal_24(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Specify plane normal. An alternative way to specify a map plane. Using
	/// this method, the object will scale the resulting texture coordinate
	/// between the SRange and TRange specified.
	/// </summary>
	public virtual void SetNormal(double _arg1, double _arg2, double _arg3)
	{
		vtkTextureMapToPlane_SetNormal_24(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToPlane_SetNormal_25(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify plane normal. An alternative way to specify a map plane. Using
	/// this method, the object will scale the resulting texture coordinate
	/// between the SRange and TRange specified.
	/// </summary>
	public virtual void SetNormal(IntPtr _arg)
	{
		vtkTextureMapToPlane_SetNormal_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToPlane_SetOrigin_26(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Specify a point defining the origin of the plane. Used in conjunction with
	/// the Point1 and Point2 ivars to specify a map plane.
	/// </summary>
	public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
	{
		vtkTextureMapToPlane_SetOrigin_26(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToPlane_SetOrigin_27(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify a point defining the origin of the plane. Used in conjunction with
	/// the Point1 and Point2 ivars to specify a map plane.
	/// </summary>
	public virtual void SetOrigin(IntPtr _arg)
	{
		vtkTextureMapToPlane_SetOrigin_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToPlane_SetPoint1_28(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Specify a point defining the first axis of the plane.
	/// </summary>
	public virtual void SetPoint1(double _arg1, double _arg2, double _arg3)
	{
		vtkTextureMapToPlane_SetPoint1_28(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToPlane_SetPoint1_29(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify a point defining the first axis of the plane.
	/// </summary>
	public virtual void SetPoint1(IntPtr _arg)
	{
		vtkTextureMapToPlane_SetPoint1_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToPlane_SetPoint2_30(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Specify a point defining the second axis of the plane.
	/// </summary>
	public virtual void SetPoint2(double _arg1, double _arg2, double _arg3)
	{
		vtkTextureMapToPlane_SetPoint2_30(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToPlane_SetPoint2_31(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify a point defining the second axis of the plane.
	/// </summary>
	public virtual void SetPoint2(IntPtr _arg)
	{
		vtkTextureMapToPlane_SetPoint2_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToPlane_SetSRange_32(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Specify s-coordinate range for texture s-t coordinate pair.
	/// </summary>
	public virtual void SetSRange(double _arg1, double _arg2)
	{
		vtkTextureMapToPlane_SetSRange_32(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToPlane_SetSRange_33(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify s-coordinate range for texture s-t coordinate pair.
	/// </summary>
	public void SetSRange(IntPtr _arg)
	{
		vtkTextureMapToPlane_SetSRange_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToPlane_SetTRange_34(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// Specify t-coordinate range for texture s-t coordinate pair.
	/// </summary>
	public virtual void SetTRange(double _arg1, double _arg2)
	{
		vtkTextureMapToPlane_SetTRange_34(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextureMapToPlane_SetTRange_35(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify t-coordinate range for texture s-t coordinate pair.
	/// </summary>
	public void SetTRange(IntPtr _arg)
	{
		vtkTextureMapToPlane_SetTRange_35(GetCppThis(), _arg);
	}
}
