using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkKCoreLayout
/// </summary>
/// <remarks>
///    Produces a layout for a graph labeled with K-Core
///                        information.
///
///
/// vtkKCoreLayout creates coordinates for each vertex that can be used to
/// perform a layout for a k-core view.
/// Prerequisite:  Vertices must have an attribute array containing their
///                k-core number.  This layout is based on the algorithm
///                described in the paper: "k-core decomposition: a tool
///                for the visualization of large scale networks", by
///                Ignacio Alvarez-Hamelin et. al.
///
///                This graph algorithm appends either polar coordinates or cartesian coordinates
///                as vertex attributes to the graph giving the position of the vertex in a layout.
///                Input graphs must have the k-core number assigned to each vertex (default
///                attribute array storing kcore numbers is "kcore").
///
///                Epsilon - this factor is used to adjust the amount vertices are 'pulled' out of
///                          their default ring radius based on the number of neighbors in higher
///                          cores.  Default=0.2
///                UnitRadius - Tweaks the base unit radius value.  Default=1.0
///
///                Still TODO: Still need to work on the connected-components within each shell and
///                            associated layout issues with that.
///
/// Input port 0: graph
///
/// @par Thanks:
/// Thanks to William McLendon from Sandia National Laboratories for providing this
/// implementation.
/// </remarks>
public class vtkKCoreLayout : vtkGraphAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkKCoreLayout";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkKCoreLayout()
	{
		MRClassNameKey = "class vtkKCoreLayout";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkKCoreLayout"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkKCoreLayout(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKCoreLayout_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkKCoreLayout New()
	{
		vtkKCoreLayout result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKCoreLayout_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkKCoreLayout)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkKCoreLayout()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkKCoreLayout_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKCoreLayout_CartesianOff_01(HandleRef pThis);

	/// <summary>
	/// Set whether or not to convert output to cartesian coordinates.  If false, coordinates
	/// will be returned in polar coordinates (radius, angle).
	/// Default: True
	/// </summary>
	public virtual void CartesianOff()
	{
		vtkKCoreLayout_CartesianOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKCoreLayout_CartesianOn_02(HandleRef pThis);

	/// <summary>
	/// Set whether or not to convert output to cartesian coordinates.  If false, coordinates
	/// will be returned in polar coordinates (radius, angle).
	/// Default: True
	/// </summary>
	public virtual void CartesianOn()
	{
		vtkKCoreLayout_CartesianOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKCoreLayout_FillInputPortInformation_03(HandleRef pThis, int port, HandleRef info);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual int FillInputPortInformation(int port, vtkInformation info)
	{
		return vtkKCoreLayout_FillInputPortInformation_03(GetCppThis(), port, info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkKCoreLayout_GetCartesian_04(HandleRef pThis);

	/// <summary>
	/// Set whether or not to convert output to cartesian coordinates.  If false, coordinates
	/// will be returned in polar coordinates (radius, angle).
	/// Default: True
	/// </summary>
	public virtual bool GetCartesian()
	{
		return (vtkKCoreLayout_GetCartesian_04(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKCoreLayout_GetCartesianCoordsXArrayName_05(HandleRef pThis);

	/// <summary>
	/// Cartesian coordinates array name for the X coordinates.
	/// This is only used if OutputCartesianCoordinates is True.
	/// Default: coord_x
	/// </summary>
	public virtual string GetCartesianCoordsXArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkKCoreLayout_GetCartesianCoordsXArrayName_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKCoreLayout_GetCartesianCoordsYArrayName_06(HandleRef pThis);

	/// <summary>
	/// Cartesian coordinates array name for the Y coordinates.
	/// This is only used if OutputCartesianCoordinates is True.
	/// Default: coord_y
	/// </summary>
	public virtual string GetCartesianCoordsYArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkKCoreLayout_GetCartesianCoordsYArrayName_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkKCoreLayout_GetEpsilon_07(HandleRef pThis);

	/// <summary>
	/// Epsilon value used in the algorithm.
	/// Default = 0.2
	/// </summary>
	public virtual float GetEpsilon()
	{
		return vtkKCoreLayout_GetEpsilon_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkKCoreLayout_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkKCoreLayout_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkKCoreLayout_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkKCoreLayout_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkKCoreLayout_GetPolar_10(HandleRef pThis);

	/// <summary>
	/// Output polar coordinates for vertices if True.  Default column names are
	/// coord_radius, coord_angle.
	/// Default: False
	/// </summary>
	public virtual bool GetPolar()
	{
		return (vtkKCoreLayout_GetPolar_10(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKCoreLayout_GetPolarCoordsAngleArrayName_11(HandleRef pThis);

	/// <summary>
	/// Polar coordinates array name for angle values in radians.
	/// This is only used if OutputCartesianCoordinates is False.
	/// Default: coord_angle
	/// </summary>
	public virtual string GetPolarCoordsAngleArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkKCoreLayout_GetPolarCoordsAngleArrayName_11(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKCoreLayout_GetPolarCoordsRadiusArrayName_12(HandleRef pThis);

	/// <summary>
	/// Polar coordinates array name for radius values.
	/// This is only used if OutputCartesianCoordinates is False.
	/// Default: coord_radius
	/// </summary>
	public virtual string GetPolarCoordsRadiusArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkKCoreLayout_GetPolarCoordsRadiusArrayName_12(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkKCoreLayout_GetUnitRadius_13(HandleRef pThis);

	/// <summary>
	/// Unit Radius value used in the algorithm.
	/// Default = 1.0
	/// </summary>
	public virtual float GetUnitRadius()
	{
		return vtkKCoreLayout_GetUnitRadius_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKCoreLayout_IsA_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkKCoreLayout_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKCoreLayout_IsTypeOf_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkKCoreLayout_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKCoreLayout_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkKCoreLayout NewInstance()
	{
		vtkKCoreLayout result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKCoreLayout_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkKCoreLayout)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKCoreLayout_PolarOff_18(HandleRef pThis);

	/// <summary>
	/// Output polar coordinates for vertices if True.  Default column names are
	/// coord_radius, coord_angle.
	/// Default: False
	/// </summary>
	public virtual void PolarOff()
	{
		vtkKCoreLayout_PolarOff_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKCoreLayout_PolarOn_19(HandleRef pThis);

	/// <summary>
	/// Output polar coordinates for vertices if True.  Default column names are
	/// coord_radius, coord_angle.
	/// Default: False
	/// </summary>
	public virtual void PolarOn()
	{
		vtkKCoreLayout_PolarOn_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKCoreLayout_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkKCoreLayout SafeDownCast(vtkObjectBase o)
	{
		vtkKCoreLayout vtkKCoreLayout2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKCoreLayout_SafeDownCast_20(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkKCoreLayout2 = (vtkKCoreLayout)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkKCoreLayout2.Register(null);
			}
		}
		return vtkKCoreLayout2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKCoreLayout_SetCartesian_21(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set whether or not to convert output to cartesian coordinates.  If false, coordinates
	/// will be returned in polar coordinates (radius, angle).
	/// Default: True
	/// </summary>
	public virtual void SetCartesian(bool _arg)
	{
		vtkKCoreLayout_SetCartesian_21(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKCoreLayout_SetCartesianCoordsXArrayName_22(HandleRef pThis, string _arg);

	/// <summary>
	/// Cartesian coordinates array name for the X coordinates.
	/// This is only used if OutputCartesianCoordinates is True.
	/// Default: coord_x
	/// </summary>
	public virtual void SetCartesianCoordsXArrayName(string _arg)
	{
		vtkKCoreLayout_SetCartesianCoordsXArrayName_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKCoreLayout_SetCartesianCoordsYArrayName_23(HandleRef pThis, string _arg);

	/// <summary>
	/// Cartesian coordinates array name for the Y coordinates.
	/// This is only used if OutputCartesianCoordinates is True.
	/// Default: coord_y
	/// </summary>
	public virtual void SetCartesianCoordsYArrayName(string _arg)
	{
		vtkKCoreLayout_SetCartesianCoordsYArrayName_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKCoreLayout_SetEpsilon_24(HandleRef pThis, float _arg);

	/// <summary>
	/// Epsilon value used in the algorithm.
	/// Default = 0.2
	/// </summary>
	public virtual void SetEpsilon(float _arg)
	{
		vtkKCoreLayout_SetEpsilon_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKCoreLayout_SetGraphConnection_25(HandleRef pThis, HandleRef arg0);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetGraphConnection(vtkAlgorithmOutput arg0)
	{
		vtkKCoreLayout_SetGraphConnection_25(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKCoreLayout_SetKCoreLabelArrayName_26(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the name of the vertex attribute array storing k-core labels.
	/// Default: kcore
	/// </summary>
	public virtual void SetKCoreLabelArrayName(string _arg)
	{
		vtkKCoreLayout_SetKCoreLabelArrayName_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKCoreLayout_SetPolar_27(HandleRef pThis, byte _arg);

	/// <summary>
	/// Output polar coordinates for vertices if True.  Default column names are
	/// coord_radius, coord_angle.
	/// Default: False
	/// </summary>
	public virtual void SetPolar(bool _arg)
	{
		vtkKCoreLayout_SetPolar_27(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKCoreLayout_SetPolarCoordsAngleArrayName_28(HandleRef pThis, string _arg);

	/// <summary>
	/// Polar coordinates array name for angle values in radians.
	/// This is only used if OutputCartesianCoordinates is False.
	/// Default: coord_angle
	/// </summary>
	public virtual void SetPolarCoordsAngleArrayName(string _arg)
	{
		vtkKCoreLayout_SetPolarCoordsAngleArrayName_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKCoreLayout_SetPolarCoordsRadiusArrayName_29(HandleRef pThis, string _arg);

	/// <summary>
	/// Polar coordinates array name for radius values.
	/// This is only used if OutputCartesianCoordinates is False.
	/// Default: coord_radius
	/// </summary>
	public virtual void SetPolarCoordsRadiusArrayName(string _arg)
	{
		vtkKCoreLayout_SetPolarCoordsRadiusArrayName_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKCoreLayout_SetUnitRadius_30(HandleRef pThis, float _arg);

	/// <summary>
	/// Unit Radius value used in the algorithm.
	/// Default = 1.0
	/// </summary>
	public virtual void SetUnitRadius(float _arg)
	{
		vtkKCoreLayout_SetUnitRadius_30(GetCppThis(), _arg);
	}
}
