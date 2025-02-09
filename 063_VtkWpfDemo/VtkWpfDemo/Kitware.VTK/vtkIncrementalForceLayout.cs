using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkIncrementalForceLayout
/// </summary>
/// <remarks>
///    incremental force-directed layout.
///
///
/// Performs an incremental force-directed layout of a graph. Set the graph
/// then iteratively execute UpdatePositions() to update the vertex positions.
/// Note that this directly modifies the vertex locations in the graph.
///
/// This layout is modeled after D3's force layout described at
/// https://github.com/mbostock/d3/wiki/Force-Layout
/// </remarks>
public class vtkIncrementalForceLayout : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkIncrementalForceLayout";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkIncrementalForceLayout()
	{
		MRClassNameKey = "class vtkIncrementalForceLayout";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkIncrementalForceLayout"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkIncrementalForceLayout(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIncrementalForceLayout_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkIncrementalForceLayout New()
	{
		vtkIncrementalForceLayout result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIncrementalForceLayout_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkIncrementalForceLayout)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkIncrementalForceLayout()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkIncrementalForceLayout_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern float vtkIncrementalForceLayout_GetAlpha_01(HandleRef pThis);

	/// <summary>
	/// Set the level of activity in the simulation. Default is 0.1.
	/// </summary>
	public virtual float GetAlpha()
	{
		return vtkIncrementalForceLayout_GetAlpha_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkIncrementalForceLayout_GetCharge_02(HandleRef pThis);

	/// <summary>
	/// Set the charge of each vertex. Higher negative values will repel vertices
	/// from each other more strongly. Default is -30.
	/// </summary>
	public virtual float GetCharge()
	{
		return vtkIncrementalForceLayout_GetCharge_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkIncrementalForceLayout_GetDistance_03(HandleRef pThis);

	/// <summary>
	/// Set the resting distance of each link in scene units, which is equal to
	/// pixels when there is no scene scaling. Default is 20.
	/// </summary>
	public virtual float GetDistance()
	{
		return vtkIncrementalForceLayout_GetDistance_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIncrementalForceLayout_GetFixed_04(HandleRef pThis);

	/// <summary>
	/// Set the id of the vertex that will not move during the simulation.
	/// Set to -1 to allow all the vertices to move.
	/// </summary>
	public virtual long GetFixed()
	{
		return vtkIncrementalForceLayout_GetFixed_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkIncrementalForceLayout_GetFriction_05(HandleRef pThis);

	/// <summary>
	/// Set the multiplier for scaling down velocity in the simulation, where values closer to 1
	/// are more frictionless. Default is 0.95.
	/// </summary>
	public virtual float GetFriction()
	{
		return vtkIncrementalForceLayout_GetFriction_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIncrementalForceLayout_GetGraph_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the graph to be positioned.
	/// </summary>
	public virtual vtkGraph GetGraph()
	{
		vtkGraph vtkGraph2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIncrementalForceLayout_GetGraph_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGraph2 = (vtkGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGraph2.Register(null);
			}
		}
		return vtkGraph2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkIncrementalForceLayout_GetGravity_07(HandleRef pThis);

	/// <summary>
	/// Set the amount of gravitational pull toward the gravity point.
	/// Default is 0.01.
	/// </summary>
	public virtual float GetGravity()
	{
		return vtkIncrementalForceLayout_GetGravity_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIncrementalForceLayout_GetGravityPoint_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the gravity point where all vertices will migrate. Generally this
	/// should be set to the location in the center of the scene.
	/// Default location is (200, 200).
	/// </summary>
	public virtual vtkVector2f GetGravityPoint()
	{
		vtkVector2f result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIncrementalForceLayout_GetGravityPoint_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVector2f)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIncrementalForceLayout_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkIncrementalForceLayout_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkIncrementalForceLayout_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkIncrementalForceLayout_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkIncrementalForceLayout_GetStrength_11(HandleRef pThis);

	/// <summary>
	/// Set the rigitity of links in the simulation. Default is 2.
	/// </summary>
	public virtual float GetStrength()
	{
		return vtkIncrementalForceLayout_GetStrength_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkIncrementalForceLayout_GetTheta_12(HandleRef pThis);

	/// <summary>
	/// Set the Barnes-Hut threshold for the simulation. Higher values
	/// will speed the simulation at the expense of some accuracy.
	/// Default is 0.8.
	/// </summary>
	public virtual float GetTheta()
	{
		return vtkIncrementalForceLayout_GetTheta_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIncrementalForceLayout_IsA_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkIncrementalForceLayout_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkIncrementalForceLayout_IsTypeOf_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkIncrementalForceLayout_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIncrementalForceLayout_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkIncrementalForceLayout NewInstance()
	{
		vtkIncrementalForceLayout result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIncrementalForceLayout_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkIncrementalForceLayout)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkIncrementalForceLayout_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkIncrementalForceLayout SafeDownCast(vtkObjectBase o)
	{
		vtkIncrementalForceLayout vtkIncrementalForceLayout2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkIncrementalForceLayout_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIncrementalForceLayout2 = (vtkIncrementalForceLayout)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIncrementalForceLayout2.Register(null);
			}
		}
		return vtkIncrementalForceLayout2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIncrementalForceLayout_SetAlpha_18(HandleRef pThis, float _arg);

	/// <summary>
	/// Set the level of activity in the simulation. Default is 0.1.
	/// </summary>
	public virtual void SetAlpha(float _arg)
	{
		vtkIncrementalForceLayout_SetAlpha_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIncrementalForceLayout_SetCharge_19(HandleRef pThis, float _arg);

	/// <summary>
	/// Set the charge of each vertex. Higher negative values will repel vertices
	/// from each other more strongly. Default is -30.
	/// </summary>
	public virtual void SetCharge(float _arg)
	{
		vtkIncrementalForceLayout_SetCharge_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIncrementalForceLayout_SetDistance_20(HandleRef pThis, float _arg);

	/// <summary>
	/// Set the resting distance of each link in scene units, which is equal to
	/// pixels when there is no scene scaling. Default is 20.
	/// </summary>
	public virtual void SetDistance(float _arg)
	{
		vtkIncrementalForceLayout_SetDistance_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIncrementalForceLayout_SetFixed_21(HandleRef pThis, long arg0);

	/// <summary>
	/// Set the id of the vertex that will not move during the simulation.
	/// Set to -1 to allow all the vertices to move.
	/// </summary>
	public virtual void SetFixed(long arg0)
	{
		vtkIncrementalForceLayout_SetFixed_21(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIncrementalForceLayout_SetFriction_22(HandleRef pThis, float _arg);

	/// <summary>
	/// Set the multiplier for scaling down velocity in the simulation, where values closer to 1
	/// are more frictionless. Default is 0.95.
	/// </summary>
	public virtual void SetFriction(float _arg)
	{
		vtkIncrementalForceLayout_SetFriction_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIncrementalForceLayout_SetGraph_23(HandleRef pThis, HandleRef g);

	/// <summary>
	/// Set the graph to be positioned.
	/// </summary>
	public virtual void SetGraph(vtkGraph g)
	{
		vtkIncrementalForceLayout_SetGraph_23(GetCppThis(), g?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIncrementalForceLayout_SetGravity_24(HandleRef pThis, float _arg);

	/// <summary>
	/// Set the amount of gravitational pull toward the gravity point.
	/// Default is 0.01.
	/// </summary>
	public virtual void SetGravity(float _arg)
	{
		vtkIncrementalForceLayout_SetGravity_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIncrementalForceLayout_SetGravityPoint_25(HandleRef pThis, HandleRef point);

	/// <summary>
	/// Set the gravity point where all vertices will migrate. Generally this
	/// should be set to the location in the center of the scene.
	/// Default location is (200, 200).
	/// </summary>
	public virtual void SetGravityPoint(vtkVector2f point)
	{
		vtkIncrementalForceLayout_SetGravityPoint_25(GetCppThis(), point?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIncrementalForceLayout_SetStrength_26(HandleRef pThis, float _arg);

	/// <summary>
	/// Set the rigitity of links in the simulation. Default is 2.
	/// </summary>
	public virtual void SetStrength(float _arg)
	{
		vtkIncrementalForceLayout_SetStrength_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIncrementalForceLayout_SetTheta_27(HandleRef pThis, float _arg);

	/// <summary>
	/// Set the Barnes-Hut threshold for the simulation. Higher values
	/// will speed the simulation at the expense of some accuracy.
	/// Default is 0.8.
	/// </summary>
	public virtual void SetTheta(float _arg)
	{
		vtkIncrementalForceLayout_SetTheta_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkIncrementalForceLayout_UpdatePositions_28(HandleRef pThis);

	/// <summary>
	/// Perform one iteration of the force-directed layout.
	/// </summary>
	public void UpdatePositions()
	{
		vtkIncrementalForceLayout_UpdatePositions_28(GetCppThis());
	}
}
