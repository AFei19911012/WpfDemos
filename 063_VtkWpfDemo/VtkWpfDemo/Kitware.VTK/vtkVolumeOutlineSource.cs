using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVolumeOutlineSource
/// </summary>
/// <remarks>
///    outline of volume cropping region
///
/// vtkVolumeOutlineSource generates a wireframe outline that corresponds
/// to the cropping region of a vtkVolumeMapper.  It requires a
/// vtkVolumeMapper as input.  The GenerateFaces option turns on the
/// solid faces of the outline, and the GenerateScalars option generates
/// color scalars.  When GenerateScalars is on, it is possible to set
/// an "ActivePlaneId" value in the range [0..6] to highlight one of the
/// six cropping planes.
/// @par Thanks:
/// Thanks to David Gobbi for contributing this class to VTK.
/// </remarks>
public class vtkVolumeOutlineSource : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVolumeOutlineSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVolumeOutlineSource()
	{
		MRClassNameKey = "class vtkVolumeOutlineSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumeOutlineSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVolumeOutlineSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeOutlineSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVolumeOutlineSource New()
	{
		vtkVolumeOutlineSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeOutlineSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVolumeOutlineSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkVolumeOutlineSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkVolumeOutlineSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeOutlineSource_GenerateFacesOff_01(HandleRef pThis);

	/// <summary>
	/// Set whether to generate polygonal faces for the output.  By default,
	/// only lines are generated.  The faces will form a closed, watertight
	/// surface.
	/// </summary>
	public virtual void GenerateFacesOff()
	{
		vtkVolumeOutlineSource_GenerateFacesOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeOutlineSource_GenerateFacesOn_02(HandleRef pThis);

	/// <summary>
	/// Set whether to generate polygonal faces for the output.  By default,
	/// only lines are generated.  The faces will form a closed, watertight
	/// surface.
	/// </summary>
	public virtual void GenerateFacesOn()
	{
		vtkVolumeOutlineSource_GenerateFacesOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeOutlineSource_GenerateOutlineOff_03(HandleRef pThis);

	/// <summary>
	/// Set whether to generate an outline wherever an input face was
	/// cut by a plane.  This is on by default.
	/// </summary>
	public virtual void GenerateOutlineOff()
	{
		vtkVolumeOutlineSource_GenerateOutlineOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeOutlineSource_GenerateOutlineOn_04(HandleRef pThis);

	/// <summary>
	/// Set whether to generate an outline wherever an input face was
	/// cut by a plane.  This is on by default.
	/// </summary>
	public virtual void GenerateOutlineOn()
	{
		vtkVolumeOutlineSource_GenerateOutlineOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeOutlineSource_GenerateScalarsOff_05(HandleRef pThis);

	/// <summary>
	/// Set whether to generate color scalars for the output.  By default,
	/// the output has no scalars and the color must be set in the
	/// property of the actor.
	/// </summary>
	public virtual void GenerateScalarsOff()
	{
		vtkVolumeOutlineSource_GenerateScalarsOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeOutlineSource_GenerateScalarsOn_06(HandleRef pThis);

	/// <summary>
	/// Set whether to generate color scalars for the output.  By default,
	/// the output has no scalars and the color must be set in the
	/// property of the actor.
	/// </summary>
	public virtual void GenerateScalarsOn()
	{
		vtkVolumeOutlineSource_GenerateScalarsOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeOutlineSource_GetActivePlaneColor_07(HandleRef pThis);

	/// <summary>
	/// Set the color of the active cropping plane.  This has no effect unless
	/// GenerateScalars is On and ActivePlaneId is non-negative.  The default
	/// color is yellow.
	/// </summary>
	public virtual double[] GetActivePlaneColor()
	{
		IntPtr intPtr = vtkVolumeOutlineSource_GetActivePlaneColor_07(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeOutlineSource_GetActivePlaneColor_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set the color of the active cropping plane.  This has no effect unless
	/// GenerateScalars is On and ActivePlaneId is non-negative.  The default
	/// color is yellow.
	/// </summary>
	public virtual void GetActivePlaneColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkVolumeOutlineSource_GetActivePlaneColor_08(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeOutlineSource_GetActivePlaneColor_09(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the color of the active cropping plane.  This has no effect unless
	/// GenerateScalars is On and ActivePlaneId is non-negative.  The default
	/// color is yellow.
	/// </summary>
	public virtual void GetActivePlaneColor(IntPtr _arg)
	{
		vtkVolumeOutlineSource_GetActivePlaneColor_09(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeOutlineSource_GetActivePlaneId_10(HandleRef pThis);

	/// <summary>
	/// Set the active plane, e.g. to display which plane is currently being
	/// modified by an interaction.  Set this to -1 if there is no active plane.
	/// The default value is -1.
	/// </summary>
	public virtual int GetActivePlaneId()
	{
		return vtkVolumeOutlineSource_GetActivePlaneId_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeOutlineSource_GetColor_11(HandleRef pThis);

	/// <summary>
	/// Set the color of the outline.  This has no effect unless GenerateScalars
	/// is On.  The default color is red.
	/// </summary>
	public virtual double[] GetColor()
	{
		IntPtr intPtr = vtkVolumeOutlineSource_GetColor_11(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeOutlineSource_GetColor_12(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set the color of the outline.  This has no effect unless GenerateScalars
	/// is On.  The default color is red.
	/// </summary>
	public virtual void GetColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkVolumeOutlineSource_GetColor_12(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeOutlineSource_GetColor_13(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the color of the outline.  This has no effect unless GenerateScalars
	/// is On.  The default color is red.
	/// </summary>
	public virtual void GetColor(IntPtr _arg)
	{
		vtkVolumeOutlineSource_GetColor_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeOutlineSource_GetGenerateFaces_14(HandleRef pThis);

	/// <summary>
	/// Set whether to generate polygonal faces for the output.  By default,
	/// only lines are generated.  The faces will form a closed, watertight
	/// surface.
	/// </summary>
	public virtual int GetGenerateFaces()
	{
		return vtkVolumeOutlineSource_GetGenerateFaces_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeOutlineSource_GetGenerateOutline_15(HandleRef pThis);

	/// <summary>
	/// Set whether to generate an outline wherever an input face was
	/// cut by a plane.  This is on by default.
	/// </summary>
	public virtual int GetGenerateOutline()
	{
		return vtkVolumeOutlineSource_GetGenerateOutline_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeOutlineSource_GetGenerateScalars_16(HandleRef pThis);

	/// <summary>
	/// Set whether to generate color scalars for the output.  By default,
	/// the output has no scalars and the color must be set in the
	/// property of the actor.
	/// </summary>
	public virtual int GetGenerateScalars()
	{
		return vtkVolumeOutlineSource_GetGenerateScalars_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVolumeOutlineSource_GetNumberOfGenerationsFromBase_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVolumeOutlineSource_GetNumberOfGenerationsFromBase_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVolumeOutlineSource_GetNumberOfGenerationsFromBaseType_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVolumeOutlineSource_GetNumberOfGenerationsFromBaseType_18(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeOutlineSource_GetVolumeMapper_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the mapper that has the cropping region that the outline will
	/// be generated for.  The mapper must have an input, because the
	/// bounds of the data must be computed in order to generate the
	/// outline.
	/// </summary>
	public vtkVolumeMapper GetVolumeMapper()
	{
		vtkVolumeMapper vtkVolumeMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeOutlineSource_GetVolumeMapper_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVolumeMapper2 = (vtkVolumeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVolumeMapper2.Register(null);
			}
		}
		return vtkVolumeMapper2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeOutlineSource_IsA_20(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVolumeOutlineSource_IsA_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeOutlineSource_IsTypeOf_21(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVolumeOutlineSource_IsTypeOf_21(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeOutlineSource_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkVolumeOutlineSource NewInstance()
	{
		vtkVolumeOutlineSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeOutlineSource_NewInstance_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVolumeOutlineSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeOutlineSource_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVolumeOutlineSource SafeDownCast(vtkObjectBase o)
	{
		vtkVolumeOutlineSource vtkVolumeOutlineSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeOutlineSource_SafeDownCast_24(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVolumeOutlineSource2 = (vtkVolumeOutlineSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVolumeOutlineSource2.Register(null);
			}
		}
		return vtkVolumeOutlineSource2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeOutlineSource_SetActivePlaneColor_25(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the color of the active cropping plane.  This has no effect unless
	/// GenerateScalars is On and ActivePlaneId is non-negative.  The default
	/// color is yellow.
	/// </summary>
	public virtual void SetActivePlaneColor(double _arg1, double _arg2, double _arg3)
	{
		vtkVolumeOutlineSource_SetActivePlaneColor_25(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeOutlineSource_SetActivePlaneColor_26(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the color of the active cropping plane.  This has no effect unless
	/// GenerateScalars is On and ActivePlaneId is non-negative.  The default
	/// color is yellow.
	/// </summary>
	public virtual void SetActivePlaneColor(IntPtr _arg)
	{
		vtkVolumeOutlineSource_SetActivePlaneColor_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeOutlineSource_SetActivePlaneId_27(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the active plane, e.g. to display which plane is currently being
	/// modified by an interaction.  Set this to -1 if there is no active plane.
	/// The default value is -1.
	/// </summary>
	public virtual void SetActivePlaneId(int _arg)
	{
		vtkVolumeOutlineSource_SetActivePlaneId_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeOutlineSource_SetColor_28(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the color of the outline.  This has no effect unless GenerateScalars
	/// is On.  The default color is red.
	/// </summary>
	public virtual void SetColor(double _arg1, double _arg2, double _arg3)
	{
		vtkVolumeOutlineSource_SetColor_28(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeOutlineSource_SetColor_29(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the color of the outline.  This has no effect unless GenerateScalars
	/// is On.  The default color is red.
	/// </summary>
	public virtual void SetColor(IntPtr _arg)
	{
		vtkVolumeOutlineSource_SetColor_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeOutlineSource_SetGenerateFaces_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Set whether to generate polygonal faces for the output.  By default,
	/// only lines are generated.  The faces will form a closed, watertight
	/// surface.
	/// </summary>
	public virtual void SetGenerateFaces(int _arg)
	{
		vtkVolumeOutlineSource_SetGenerateFaces_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeOutlineSource_SetGenerateOutline_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Set whether to generate an outline wherever an input face was
	/// cut by a plane.  This is on by default.
	/// </summary>
	public virtual void SetGenerateOutline(int _arg)
	{
		vtkVolumeOutlineSource_SetGenerateOutline_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeOutlineSource_SetGenerateScalars_32(HandleRef pThis, int _arg);

	/// <summary>
	/// Set whether to generate color scalars for the output.  By default,
	/// the output has no scalars and the color must be set in the
	/// property of the actor.
	/// </summary>
	public virtual void SetGenerateScalars(int _arg)
	{
		vtkVolumeOutlineSource_SetGenerateScalars_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeOutlineSource_SetVolumeMapper_33(HandleRef pThis, HandleRef mapper);

	/// <summary>
	/// Set the mapper that has the cropping region that the outline will
	/// be generated for.  The mapper must have an input, because the
	/// bounds of the data must be computed in order to generate the
	/// outline.
	/// </summary>
	public virtual void SetVolumeMapper(vtkVolumeMapper mapper)
	{
		vtkVolumeOutlineSource_SetVolumeMapper_33(GetCppThis(), mapper?.GetCppThis() ?? default(HandleRef));
	}
}
