using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLODProp3D
/// </summary>
/// <remarks>
///    level of detail 3D prop
///
/// vtkLODProp3D is a class to support level of detail rendering for Prop3D.
/// Any number of mapper/property/texture items can be added to this object.
/// Render time will be measured, and will be used to select a LOD based on
/// the AllocatedRenderTime of this Prop3D. Depending on the type of the
/// mapper/property, a vtkActor or a vtkVolume will be created behind the
/// scenes.
///
/// </remarks>
/// <seealso>
///
/// vtkProp3D vtkActor vtkVolume vtkLODActor
/// </seealso>
public class vtkLODProp3D : vtkProp3D
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLODProp3D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLODProp3D()
	{
		MRClassNameKey = "class vtkLODProp3D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLODProp3D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLODProp3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLODProp3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create an instance of this class.
	/// </summary>
	public new static vtkLODProp3D New()
	{
		vtkLODProp3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLODProp3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLODProp3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Create an instance of this class.
	/// </summary>
	public vtkLODProp3D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLODProp3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkLODProp3D_AddEstimatedRenderTime_01(HandleRef pThis, double t, HandleRef vp);

	/// <summary>
	/// Override method from vtkProp in order to push this call down to the
	/// selected LOD as well.
	/// </summary>
	public override void AddEstimatedRenderTime(double t, vtkViewport vp)
	{
		vtkLODProp3D_AddEstimatedRenderTime_01(GetCppThis(), t, vp?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLODProp3D_AddLOD_02(HandleRef pThis, HandleRef m, HandleRef p, HandleRef back, HandleRef t, double time);

	/// <summary>
	/// Add a level of detail with a given mapper, property, backface property,
	/// texture, and guess of rendering time.  The property and texture fields
	/// can be set to NULL (the other methods are included for script access
	/// where null variables are not allowed). The time field can be set to 0.0
	/// indicating that no initial guess for rendering time is being supplied.
	/// The returned integer value is an ID that can be used later to delete
	/// this LOD, or set it as the selected LOD.
	/// </summary>
	public int AddLOD(vtkMapper m, vtkProperty p, vtkProperty back, vtkTexture t, double time)
	{
		return vtkLODProp3D_AddLOD_02(GetCppThis(), m?.GetCppThis() ?? default(HandleRef), p?.GetCppThis() ?? default(HandleRef), back?.GetCppThis() ?? default(HandleRef), t?.GetCppThis() ?? default(HandleRef), time);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLODProp3D_AddLOD_03(HandleRef pThis, HandleRef m, HandleRef p, HandleRef t, double time);

	/// <summary>
	/// Add a level of detail with a given mapper, property, backface property,
	/// texture, and guess of rendering time.  The property and texture fields
	/// can be set to NULL (the other methods are included for script access
	/// where null variables are not allowed). The time field can be set to 0.0
	/// indicating that no initial guess for rendering time is being supplied.
	/// The returned integer value is an ID that can be used later to delete
	/// this LOD, or set it as the selected LOD.
	/// </summary>
	public int AddLOD(vtkMapper m, vtkProperty p, vtkTexture t, double time)
	{
		return vtkLODProp3D_AddLOD_03(GetCppThis(), m?.GetCppThis() ?? default(HandleRef), p?.GetCppThis() ?? default(HandleRef), t?.GetCppThis() ?? default(HandleRef), time);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLODProp3D_AddLOD_04(HandleRef pThis, HandleRef m, HandleRef p, HandleRef back, double time);

	/// <summary>
	/// Add a level of detail with a given mapper, property, backface property,
	/// texture, and guess of rendering time.  The property and texture fields
	/// can be set to NULL (the other methods are included for script access
	/// where null variables are not allowed). The time field can be set to 0.0
	/// indicating that no initial guess for rendering time is being supplied.
	/// The returned integer value is an ID that can be used later to delete
	/// this LOD, or set it as the selected LOD.
	/// </summary>
	public int AddLOD(vtkMapper m, vtkProperty p, vtkProperty back, double time)
	{
		return vtkLODProp3D_AddLOD_04(GetCppThis(), m?.GetCppThis() ?? default(HandleRef), p?.GetCppThis() ?? default(HandleRef), back?.GetCppThis() ?? default(HandleRef), time);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLODProp3D_AddLOD_05(HandleRef pThis, HandleRef m, HandleRef p, double time);

	/// <summary>
	/// Add a level of detail with a given mapper, property, backface property,
	/// texture, and guess of rendering time.  The property and texture fields
	/// can be set to NULL (the other methods are included for script access
	/// where null variables are not allowed). The time field can be set to 0.0
	/// indicating that no initial guess for rendering time is being supplied.
	/// The returned integer value is an ID that can be used later to delete
	/// this LOD, or set it as the selected LOD.
	/// </summary>
	public int AddLOD(vtkMapper m, vtkProperty p, double time)
	{
		return vtkLODProp3D_AddLOD_05(GetCppThis(), m?.GetCppThis() ?? default(HandleRef), p?.GetCppThis() ?? default(HandleRef), time);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLODProp3D_AddLOD_06(HandleRef pThis, HandleRef m, HandleRef t, double time);

	/// <summary>
	/// Add a level of detail with a given mapper, property, backface property,
	/// texture, and guess of rendering time.  The property and texture fields
	/// can be set to NULL (the other methods are included for script access
	/// where null variables are not allowed). The time field can be set to 0.0
	/// indicating that no initial guess for rendering time is being supplied.
	/// The returned integer value is an ID that can be used later to delete
	/// this LOD, or set it as the selected LOD.
	/// </summary>
	public int AddLOD(vtkMapper m, vtkTexture t, double time)
	{
		return vtkLODProp3D_AddLOD_06(GetCppThis(), m?.GetCppThis() ?? default(HandleRef), t?.GetCppThis() ?? default(HandleRef), time);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLODProp3D_AddLOD_07(HandleRef pThis, HandleRef m, double time);

	/// <summary>
	/// Add a level of detail with a given mapper, property, backface property,
	/// texture, and guess of rendering time.  The property and texture fields
	/// can be set to NULL (the other methods are included for script access
	/// where null variables are not allowed). The time field can be set to 0.0
	/// indicating that no initial guess for rendering time is being supplied.
	/// The returned integer value is an ID that can be used later to delete
	/// this LOD, or set it as the selected LOD.
	/// </summary>
	public int AddLOD(vtkMapper m, double time)
	{
		return vtkLODProp3D_AddLOD_07(GetCppThis(), m?.GetCppThis() ?? default(HandleRef), time);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLODProp3D_AddLOD_08(HandleRef pThis, HandleRef m, HandleRef p, double time);

	/// <summary>
	/// Add a level of detail with a given mapper, property, backface property,
	/// texture, and guess of rendering time.  The property and texture fields
	/// can be set to NULL (the other methods are included for script access
	/// where null variables are not allowed). The time field can be set to 0.0
	/// indicating that no initial guess for rendering time is being supplied.
	/// The returned integer value is an ID that can be used later to delete
	/// this LOD, or set it as the selected LOD.
	/// </summary>
	public int AddLOD(vtkAbstractVolumeMapper m, vtkVolumeProperty p, double time)
	{
		return vtkLODProp3D_AddLOD_08(GetCppThis(), m?.GetCppThis() ?? default(HandleRef), p?.GetCppThis() ?? default(HandleRef), time);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLODProp3D_AddLOD_09(HandleRef pThis, HandleRef m, double time);

	/// <summary>
	/// Add a level of detail with a given mapper, property, backface property,
	/// texture, and guess of rendering time.  The property and texture fields
	/// can be set to NULL (the other methods are included for script access
	/// where null variables are not allowed). The time field can be set to 0.0
	/// indicating that no initial guess for rendering time is being supplied.
	/// The returned integer value is an ID that can be used later to delete
	/// this LOD, or set it as the selected LOD.
	/// </summary>
	public int AddLOD(vtkAbstractVolumeMapper m, double time)
	{
		return vtkLODProp3D_AddLOD_09(GetCppThis(), m?.GetCppThis() ?? default(HandleRef), time);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLODProp3D_AddLOD_10(HandleRef pThis, HandleRef m, HandleRef p, double time);

	/// <summary>
	/// Add a level of detail with a given mapper, property, backface property,
	/// texture, and guess of rendering time.  The property and texture fields
	/// can be set to NULL (the other methods are included for script access
	/// where null variables are not allowed). The time field can be set to 0.0
	/// indicating that no initial guess for rendering time is being supplied.
	/// The returned integer value is an ID that can be used later to delete
	/// this LOD, or set it as the selected LOD.
	/// </summary>
	public int AddLOD(vtkImageMapper3D m, vtkImageProperty p, double time)
	{
		return vtkLODProp3D_AddLOD_10(GetCppThis(), m?.GetCppThis() ?? default(HandleRef), p?.GetCppThis() ?? default(HandleRef), time);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLODProp3D_AddLOD_11(HandleRef pThis, HandleRef m, double time);

	/// <summary>
	/// Add a level of detail with a given mapper, property, backface property,
	/// texture, and guess of rendering time.  The property and texture fields
	/// can be set to NULL (the other methods are included for script access
	/// where null variables are not allowed). The time field can be set to 0.0
	/// indicating that no initial guess for rendering time is being supplied.
	/// The returned integer value is an ID that can be used later to delete
	/// this LOD, or set it as the selected LOD.
	/// </summary>
	public int AddLOD(vtkImageMapper3D m, double time)
	{
		return vtkLODProp3D_AddLOD_11(GetCppThis(), m?.GetCppThis() ?? default(HandleRef), time);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLODProp3D_AutomaticLODSelectionOff_12(HandleRef pThis);

	/// <summary>
	/// Turn on / off automatic selection of LOD.
	/// This is on by default. If it is off, then the SelectedLODID is
	/// rendered regardless of rendering time or desired update rate.
	/// </summary>
	public virtual void AutomaticLODSelectionOff()
	{
		vtkLODProp3D_AutomaticLODSelectionOff_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLODProp3D_AutomaticLODSelectionOn_13(HandleRef pThis);

	/// <summary>
	/// Turn on / off automatic selection of LOD.
	/// This is on by default. If it is off, then the SelectedLODID is
	/// rendered regardless of rendering time or desired update rate.
	/// </summary>
	public virtual void AutomaticLODSelectionOn()
	{
		vtkLODProp3D_AutomaticLODSelectionOn_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLODProp3D_AutomaticPickLODSelectionOff_14(HandleRef pThis);

	/// <summary>
	/// Turn on / off automatic selection of picking LOD.
	/// This is on by default. If it is off, then the SelectedLODID is
	/// rendered regardless of rendering time or desired update rate.
	/// </summary>
	public virtual void AutomaticPickLODSelectionOff()
	{
		vtkLODProp3D_AutomaticPickLODSelectionOff_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLODProp3D_AutomaticPickLODSelectionOn_15(HandleRef pThis);

	/// <summary>
	/// Turn on / off automatic selection of picking LOD.
	/// This is on by default. If it is off, then the SelectedLODID is
	/// rendered regardless of rendering time or desired update rate.
	/// </summary>
	public virtual void AutomaticPickLODSelectionOn()
	{
		vtkLODProp3D_AutomaticPickLODSelectionOn_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLODProp3D_DisableLOD_16(HandleRef pThis, int id);

	/// <summary>
	/// Enable / disable a particular LOD. If it is disabled, it will not
	/// be used during automatic selection, but can be selected as the
	/// LOD if automatic LOD selection is off.
	/// </summary>
	public void DisableLOD(int id)
	{
		vtkLODProp3D_DisableLOD_16(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLODProp3D_EnableLOD_17(HandleRef pThis, int id);

	/// <summary>
	/// Enable / disable a particular LOD. If it is disabled, it will not
	/// be used during automatic selection, but can be selected as the
	/// LOD if automatic LOD selection is off.
	/// </summary>
	public void EnableLOD(int id)
	{
		vtkLODProp3D_EnableLOD_17(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLODProp3D_GetActors_18(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// For some exporters and other other operations we must be
	/// able to collect all the actors or volumes. These methods
	/// are used in that process.
	/// </summary>
	public override void GetActors(vtkPropCollection arg0)
	{
		vtkLODProp3D_GetActors_18(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLODProp3D_GetAutomaticLODSelection_19(HandleRef pThis);

	/// <summary>
	/// Turn on / off automatic selection of LOD.
	/// This is on by default. If it is off, then the SelectedLODID is
	/// rendered regardless of rendering time or desired update rate.
	/// </summary>
	public virtual int GetAutomaticLODSelection()
	{
		return vtkLODProp3D_GetAutomaticLODSelection_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLODProp3D_GetAutomaticLODSelectionMaxValue_20(HandleRef pThis);

	/// <summary>
	/// Turn on / off automatic selection of LOD.
	/// This is on by default. If it is off, then the SelectedLODID is
	/// rendered regardless of rendering time or desired update rate.
	/// </summary>
	public virtual int GetAutomaticLODSelectionMaxValue()
	{
		return vtkLODProp3D_GetAutomaticLODSelectionMaxValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLODProp3D_GetAutomaticLODSelectionMinValue_21(HandleRef pThis);

	/// <summary>
	/// Turn on / off automatic selection of LOD.
	/// This is on by default. If it is off, then the SelectedLODID is
	/// rendered regardless of rendering time or desired update rate.
	/// </summary>
	public virtual int GetAutomaticLODSelectionMinValue()
	{
		return vtkLODProp3D_GetAutomaticLODSelectionMinValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLODProp3D_GetAutomaticPickLODSelection_22(HandleRef pThis);

	/// <summary>
	/// Turn on / off automatic selection of picking LOD.
	/// This is on by default. If it is off, then the SelectedLODID is
	/// rendered regardless of rendering time or desired update rate.
	/// </summary>
	public virtual int GetAutomaticPickLODSelection()
	{
		return vtkLODProp3D_GetAutomaticPickLODSelection_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLODProp3D_GetAutomaticPickLODSelectionMaxValue_23(HandleRef pThis);

	/// <summary>
	/// Turn on / off automatic selection of picking LOD.
	/// This is on by default. If it is off, then the SelectedLODID is
	/// rendered regardless of rendering time or desired update rate.
	/// </summary>
	public virtual int GetAutomaticPickLODSelectionMaxValue()
	{
		return vtkLODProp3D_GetAutomaticPickLODSelectionMaxValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLODProp3D_GetAutomaticPickLODSelectionMinValue_24(HandleRef pThis);

	/// <summary>
	/// Turn on / off automatic selection of picking LOD.
	/// This is on by default. If it is off, then the SelectedLODID is
	/// rendered regardless of rendering time or desired update rate.
	/// </summary>
	public virtual int GetAutomaticPickLODSelectionMinValue()
	{
		return vtkLODProp3D_GetAutomaticPickLODSelectionMinValue_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLODProp3D_GetBounds_25(HandleRef pThis);

	/// <summary>
	/// Standard vtkProp method to get 3D bounds of a 3D prop
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkLODProp3D_GetBounds_25(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLODProp3D_GetBounds_26(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Standard vtkProp method to get 3D bounds of a 3D prop
	/// </summary>
	public new void GetBounds(IntPtr bounds)
	{
		vtkLODProp3D_GetBounds_26(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLODProp3D_GetCurrentIndex_27(HandleRef pThis);

	/// <summary>
	/// Get the current index, used to determine the ID of the next LOD that is
	/// added.  Useful for guessing what IDs have been used (with NumberOfLODs,
	/// without depending on the constructor initialization to 1000.
	/// </summary>
	public virtual int GetCurrentIndex()
	{
		return vtkLODProp3D_GetCurrentIndex_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLODProp3D_GetLODEstimatedRenderTime_28(HandleRef pThis, int id);

	/// <summary>
	/// Access method that can be used to find out the estimated render time
	/// (the thing used to select an LOD) for a given LOD ID or index.
	/// Value is returned in seconds.
	/// </summary>
	public double GetLODEstimatedRenderTime(int id)
	{
		return vtkLODProp3D_GetLODEstimatedRenderTime_28(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLODProp3D_GetLODIndexEstimatedRenderTime_29(HandleRef pThis, int index);

	/// <summary>
	/// Access method that can be used to find out the estimated render time
	/// (the thing used to select an LOD) for a given LOD ID or index.
	/// Value is returned in seconds.
	/// </summary>
	public double GetLODIndexEstimatedRenderTime(int index)
	{
		return vtkLODProp3D_GetLODIndexEstimatedRenderTime_29(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLODProp3D_GetLODIndexLevel_30(HandleRef pThis, int index);

	/// <summary>
	/// Set the level of a particular LOD. When a LOD is selected for
	/// rendering because it has the largest render time that fits within
	/// the allocated time, all LOD are then checked to see if any one can
	/// render faster but has a lower (more resolution/better) level.
	/// This quantity is a double to ensure that a level can be inserted
	/// between 2 and 3.
	/// </summary>
	public double GetLODIndexLevel(int index)
	{
		return vtkLODProp3D_GetLODIndexLevel_30(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkLODProp3D_GetLODLevel_31(HandleRef pThis, int id);

	/// <summary>
	/// Set the level of a particular LOD. When a LOD is selected for
	/// rendering because it has the largest render time that fits within
	/// the allocated time, all LOD are then checked to see if any one can
	/// render faster but has a lower (more resolution/better) level.
	/// This quantity is a double to ensure that a level can be inserted
	/// between 2 and 3.
	/// </summary>
	public double GetLODLevel(int id)
	{
		return vtkLODProp3D_GetLODLevel_31(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLODProp3D_GetLODMapper_32(HandleRef pThis, int id, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the LODMapper as an vtkAbstractMapper3D.  It is the user's
	/// respondibility to safe down cast this to a vtkMapper or vtkVolumeMapper
	/// as appropriate.
	/// </summary>
	public vtkAbstractMapper3D GetLODMapper(int id)
	{
		vtkAbstractMapper3D vtkAbstractMapper3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLODProp3D_GetLODMapper_32(GetCppThis(), id, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractMapper3D2 = (vtkAbstractMapper3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractMapper3D2.Register(null);
			}
		}
		return vtkAbstractMapper3D2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLODProp3D_GetLastRenderedLODID_33(HandleRef pThis);

	/// <summary>
	/// Get the ID of the previously (during the last render) selected LOD index
	/// </summary>
	public int GetLastRenderedLODID()
	{
		return vtkLODProp3D_GetLastRenderedLODID_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLODProp3D_GetNumberOfGenerationsFromBase_34(HandleRef pThis, string type);

	/// <summary>
	/// Create an instance of this class.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLODProp3D_GetNumberOfGenerationsFromBase_34(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLODProp3D_GetNumberOfGenerationsFromBaseType_35(string type);

	/// <summary>
	/// Create an instance of this class.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLODProp3D_GetNumberOfGenerationsFromBaseType_35(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLODProp3D_GetNumberOfLODs_36(HandleRef pThis);

	/// <summary>
	/// Get the current number of LODs.
	/// </summary>
	public virtual int GetNumberOfLODs()
	{
		return vtkLODProp3D_GetNumberOfLODs_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLODProp3D_GetPickLODID_37(HandleRef pThis);

	/// <summary>
	/// Get the ID of the appropriate pick LOD index
	/// </summary>
	public int GetPickLODID()
	{
		return vtkLODProp3D_GetPickLODID_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLODProp3D_GetSelectedLODID_38(HandleRef pThis);

	/// <summary>
	/// Set the id of the LOD that is to be drawn when automatic LOD selection
	/// is turned off.
	/// </summary>
	public virtual int GetSelectedLODID()
	{
		return vtkLODProp3D_GetSelectedLODID_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLODProp3D_GetSelectedPickLODID_39(HandleRef pThis);

	/// <summary>
	/// Set the id of the LOD that is to be used for picking when automatic
	/// LOD pick selection is turned off.
	/// </summary>
	public virtual int GetSelectedPickLODID()
	{
		return vtkLODProp3D_GetSelectedPickLODID_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLODProp3D_GetVolumes_40(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// For some exporters and other other operations we must be
	/// able to collect all the actors or volumes. These methods
	/// are used in that process.
	/// </summary>
	public override void GetVolumes(vtkPropCollection arg0)
	{
		vtkLODProp3D_GetVolumes_40(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLODProp3D_HasTranslucentPolygonalGeometry_41(HandleRef pThis);

	/// <summary>
	/// Does this prop have some translucent polygonal geometry?
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkLODProp3D_HasTranslucentPolygonalGeometry_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLODProp3D_IsA_42(HandleRef pThis, string type);

	/// <summary>
	/// Create an instance of this class.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLODProp3D_IsA_42(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLODProp3D_IsLODEnabled_43(HandleRef pThis, int id);

	/// <summary>
	/// Enable / disable a particular LOD. If it is disabled, it will not
	/// be used during automatic selection, but can be selected as the
	/// LOD if automatic LOD selection is off.
	/// </summary>
	public int IsLODEnabled(int id)
	{
		return vtkLODProp3D_IsLODEnabled_43(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLODProp3D_IsTypeOf_44(string type);

	/// <summary>
	/// Create an instance of this class.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLODProp3D_IsTypeOf_44(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLODProp3D_NewInstance_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create an instance of this class.
	/// </summary>
	public new vtkLODProp3D NewInstance()
	{
		vtkLODProp3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLODProp3D_NewInstance_46(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLODProp3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLODProp3D_ReleaseGraphicsResources_47(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this actor.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkLODProp3D_ReleaseGraphicsResources_47(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLODProp3D_RemoveLOD_48(HandleRef pThis, int id);

	/// <summary>
	/// Delete a level of detail given an ID. This is the ID returned by the
	/// AddLOD method
	/// </summary>
	public void RemoveLOD(int id)
	{
		vtkLODProp3D_RemoveLOD_48(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLODProp3D_RenderOpaqueGeometry_49(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Support the standard render methods.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport viewport)
	{
		return vtkLODProp3D_RenderOpaqueGeometry_49(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLODProp3D_RenderTranslucentPolygonalGeometry_50(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Support the standard render methods.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
	{
		return vtkLODProp3D_RenderTranslucentPolygonalGeometry_50(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLODProp3D_RenderVolumetricGeometry_51(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Support the standard render methods.
	/// </summary>
	public override int RenderVolumetricGeometry(vtkViewport viewport)
	{
		return vtkLODProp3D_RenderVolumetricGeometry_51(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLODProp3D_RestoreEstimatedRenderTime_52(HandleRef pThis);

	/// <summary>
	/// Used when the render process is aborted to restore the previous
	/// estimated render time. Overridden here to allow previous time for a
	/// particular LOD to be restored - otherwise the time for the last rendered
	/// LOD will be copied into the currently selected LOD.
	/// </summary>
	public override void RestoreEstimatedRenderTime()
	{
		vtkLODProp3D_RestoreEstimatedRenderTime_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLODProp3D_SafeDownCast_53(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create an instance of this class.
	/// </summary>
	public new static vtkLODProp3D SafeDownCast(vtkObjectBase o)
	{
		vtkLODProp3D vtkLODProp3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLODProp3D_SafeDownCast_53(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLODProp3D2 = (vtkLODProp3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLODProp3D2.Register(null);
			}
		}
		return vtkLODProp3D2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLODProp3D_SetAllocatedRenderTime_54(HandleRef pThis, double t, HandleRef vp);

	/// <summary>
	/// Used by the culler / renderer to set the allocated render time for this
	/// prop. This is based on the desired update rate, and possibly some other
	/// properties such as potential screen coverage of this prop.
	/// </summary>
	public override void SetAllocatedRenderTime(double t, vtkViewport vp)
	{
		vtkLODProp3D_SetAllocatedRenderTime_54(GetCppThis(), t, vp?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLODProp3D_SetAutomaticLODSelection_55(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on / off automatic selection of LOD.
	/// This is on by default. If it is off, then the SelectedLODID is
	/// rendered regardless of rendering time or desired update rate.
	/// </summary>
	public virtual void SetAutomaticLODSelection(int _arg)
	{
		vtkLODProp3D_SetAutomaticLODSelection_55(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLODProp3D_SetAutomaticPickLODSelection_56(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on / off automatic selection of picking LOD.
	/// This is on by default. If it is off, then the SelectedLODID is
	/// rendered regardless of rendering time or desired update rate.
	/// </summary>
	public virtual void SetAutomaticPickLODSelection(int _arg)
	{
		vtkLODProp3D_SetAutomaticPickLODSelection_56(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLODProp3D_SetLODBackfaceProperty_57(HandleRef pThis, int id, HandleRef t);

	/// <summary>
	/// Methods to set / get the backface property of an LOD. This method is only
	/// valid for LOD ids that are Actors (not Volumes)
	/// </summary>
	public void SetLODBackfaceProperty(int id, vtkProperty t)
	{
		vtkLODProp3D_SetLODBackfaceProperty_57(GetCppThis(), id, t?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLODProp3D_SetLODLevel_58(HandleRef pThis, int id, double level);

	/// <summary>
	/// Set the level of a particular LOD. When a LOD is selected for
	/// rendering because it has the largest render time that fits within
	/// the allocated time, all LOD are then checked to see if any one can
	/// render faster but has a lower (more resolution/better) level.
	/// This quantity is a double to ensure that a level can be inserted
	/// between 2 and 3.
	/// </summary>
	public void SetLODLevel(int id, double level)
	{
		vtkLODProp3D_SetLODLevel_58(GetCppThis(), id, level);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLODProp3D_SetLODMapper_59(HandleRef pThis, int id, HandleRef m);

	/// <summary>
	/// Methods to set / get the mapper of an LOD. Since the LOD could be
	/// a volume or an actor, you have to pass in the pointer to the mapper
	/// to get it. The returned mapper will be NULL if the id is not valid,
	/// or the mapper is of the wrong type for the corresponding Prop3D.
	/// </summary>
	public void SetLODMapper(int id, vtkMapper m)
	{
		vtkLODProp3D_SetLODMapper_59(GetCppThis(), id, m?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLODProp3D_SetLODMapper_60(HandleRef pThis, int id, HandleRef m);

	/// <summary>
	/// Methods to set / get the mapper of an LOD. Since the LOD could be
	/// a volume or an actor, you have to pass in the pointer to the mapper
	/// to get it. The returned mapper will be NULL if the id is not valid,
	/// or the mapper is of the wrong type for the corresponding Prop3D.
	/// </summary>
	public void SetLODMapper(int id, vtkAbstractVolumeMapper m)
	{
		vtkLODProp3D_SetLODMapper_60(GetCppThis(), id, m?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLODProp3D_SetLODMapper_61(HandleRef pThis, int id, HandleRef m);

	/// <summary>
	/// Methods to set / get the mapper of an LOD. Since the LOD could be
	/// a volume or an actor, you have to pass in the pointer to the mapper
	/// to get it. The returned mapper will be NULL if the id is not valid,
	/// or the mapper is of the wrong type for the corresponding Prop3D.
	/// </summary>
	public void SetLODMapper(int id, vtkImageMapper3D m)
	{
		vtkLODProp3D_SetLODMapper_61(GetCppThis(), id, m?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLODProp3D_SetLODProperty_62(HandleRef pThis, int id, HandleRef p);

	/// <summary>
	/// Methods to set / get the property of an LOD. Since the LOD could be
	/// a volume or an actor, you have to pass in the pointer to the property
	/// to get it. The returned property will be NULL if the id is not valid,
	/// or the property is of the wrong type for the corresponding Prop3D.
	/// </summary>
	public void SetLODProperty(int id, vtkProperty p)
	{
		vtkLODProp3D_SetLODProperty_62(GetCppThis(), id, p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLODProp3D_SetLODProperty_63(HandleRef pThis, int id, HandleRef p);

	/// <summary>
	/// Methods to set / get the property of an LOD. Since the LOD could be
	/// a volume or an actor, you have to pass in the pointer to the property
	/// to get it. The returned property will be NULL if the id is not valid,
	/// or the property is of the wrong type for the corresponding Prop3D.
	/// </summary>
	public void SetLODProperty(int id, vtkVolumeProperty p)
	{
		vtkLODProp3D_SetLODProperty_63(GetCppThis(), id, p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLODProp3D_SetLODProperty_64(HandleRef pThis, int id, HandleRef p);

	/// <summary>
	/// Methods to set / get the property of an LOD. Since the LOD could be
	/// a volume or an actor, you have to pass in the pointer to the property
	/// to get it. The returned property will be NULL if the id is not valid,
	/// or the property is of the wrong type for the corresponding Prop3D.
	/// </summary>
	public void SetLODProperty(int id, vtkImageProperty p)
	{
		vtkLODProp3D_SetLODProperty_64(GetCppThis(), id, p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLODProp3D_SetLODTexture_65(HandleRef pThis, int id, HandleRef t);

	/// <summary>
	/// Methods to set / get the texture of an LOD. This method is only
	/// valid for LOD ids that are Actors (not Volumes)
	/// </summary>
	public void SetLODTexture(int id, vtkTexture t)
	{
		vtkLODProp3D_SetLODTexture_65(GetCppThis(), id, t?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLODProp3D_SetSelectedLODID_66(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the id of the LOD that is to be drawn when automatic LOD selection
	/// is turned off.
	/// </summary>
	public virtual void SetSelectedLODID(int _arg)
	{
		vtkLODProp3D_SetSelectedLODID_66(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLODProp3D_SetSelectedPickLODID_67(HandleRef pThis, int id);

	/// <summary>
	/// Set the id of the LOD that is to be used for picking when automatic
	/// LOD pick selection is turned off.
	/// </summary>
	public void SetSelectedPickLODID(int id)
	{
		vtkLODProp3D_SetSelectedPickLODID_67(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLODProp3D_ShallowCopy_68(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Shallow copy of this vtkLODProp3D.
	/// </summary>
	public override void ShallowCopy(vtkProp prop)
	{
		vtkLODProp3D_ShallowCopy_68(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}
}
