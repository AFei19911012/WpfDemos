using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMoleculeMapper
/// </summary>
/// <remarks>
///    Mapper that draws vtkMolecule objects
///
///
/// vtkMoleculeMapper uses glyphs (display lists) to quickly render a
/// molecule.
/// </remarks>
public class vtkMoleculeMapper : vtkMapper
{
	/// <summary>
	/// Get/Set whether or not to render the unit cell lattice, if present.
	/// Default: On.
	/// </summary>
	public enum CovalentRadius_WrapperEnum
	{
		/// <summary>enum member</summary>
		CovalentRadius = 0,
		/// <summary>enum member</summary>
		CustomArrayRadius = 3,
		/// <summary>enum member</summary>
		UnitRadius = 2,
		/// <summary>enum member</summary>
		VDWRadius = 1
	}

	/// <summary>
	/// Get/Set whether multicylinders will be used to represent multiple
	/// bonds. Default: On.
	/// </summary>
	public enum DiscreteByAtom_WrapperEnum
	{
		/// <summary>enum member</summary>
		DiscreteByAtom = 1,
		/// <summary>enum member</summary>
		SingleColor = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMoleculeMapper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMoleculeMapper()
	{
		MRClassNameKey = "class vtkMoleculeMapper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMoleculeMapper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMoleculeMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMoleculeMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMoleculeMapper New()
	{
		vtkMoleculeMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMoleculeMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMoleculeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMoleculeMapper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMoleculeMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMoleculeMapper_FillInputPortInformation_01(HandleRef pThis, int port, HandleRef info);

	/// <summary>
	/// Reimplemented from base class
	/// </summary>
	public virtual int FillInputPortInformation(int port, vtkInformation info)
	{
		return vtkMoleculeMapper_FillInputPortInformation_01(GetCppThis(), port, info?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMoleculeMapper_GetAtomColor_02(HandleRef pThis);

	/// <summary>
	/// Get/Set the color of the atoms as an rgb tuple.
	/// Default: {150, 150, 150} (grey)
	/// </summary>
	public virtual byte[] GetAtomColor()
	{
		IntPtr intPtr = vtkMoleculeMapper_GetAtomColor_02(GetCppThis());
		byte[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new byte[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_GetAtomColor_03(HandleRef pThis, ref byte _arg1, ref byte _arg2, ref byte _arg3);

	/// <summary>
	/// Get/Set the color of the atoms as an rgb tuple.
	/// Default: {150, 150, 150} (grey)
	/// </summary>
	public virtual void GetAtomColor(ref byte _arg1, ref byte _arg2, ref byte _arg3)
	{
		vtkMoleculeMapper_GetAtomColor_03(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_GetAtomColor_04(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the color of the atoms as an rgb tuple.
	/// Default: {150, 150, 150} (grey)
	/// </summary>
	public virtual void GetAtomColor(IntPtr _arg)
	{
		vtkMoleculeMapper_GetAtomColor_04(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMoleculeMapper_GetAtomColorMode_05(HandleRef pThis);

	/// <summary>
	/// Get/Set the method by which atoms are colored.
	///
	/// If 'SingleColor' is used, all atoms will have the same color. Use
	/// SetAtomColor to set the rgb values to be used.
	///
	/// If 'DiscreteByAtom' is selected, each atom is colored using the
	/// internal lookup table.
	/// </summary>
	public virtual int GetAtomColorMode()
	{
		return vtkMoleculeMapper_GetAtomColorMode_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMoleculeMapper_GetAtomColorModeMaxValue_06(HandleRef pThis);

	/// <summary>
	/// Get/Set the method by which atoms are colored.
	///
	/// If 'SingleColor' is used, all atoms will have the same color. Use
	/// SetAtomColor to set the rgb values to be used.
	///
	/// If 'DiscreteByAtom' is selected, each atom is colored using the
	/// internal lookup table.
	/// </summary>
	public virtual int GetAtomColorModeMaxValue()
	{
		return vtkMoleculeMapper_GetAtomColorModeMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMoleculeMapper_GetAtomColorModeMinValue_07(HandleRef pThis);

	/// <summary>
	/// Get/Set the method by which atoms are colored.
	///
	/// If 'SingleColor' is used, all atoms will have the same color. Use
	/// SetAtomColor to set the rgb values to be used.
	///
	/// If 'DiscreteByAtom' is selected, each atom is colored using the
	/// internal lookup table.
	/// </summary>
	public virtual int GetAtomColorModeMinValue()
	{
		return vtkMoleculeMapper_GetAtomColorModeMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMoleculeMapper_GetAtomicRadiusArrayName_08(HandleRef pThis);

	/// <summary>
	/// Get/Set the atomic radius array name. Default: "radii"
	/// It is only used when AtomicRadiusType is set to CustomArrayRadius.
	/// </summary>
	public virtual string GetAtomicRadiusArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkMoleculeMapper_GetAtomicRadiusArrayName_08(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkMoleculeMapper_GetAtomicRadiusScaleFactor_09(HandleRef pThis);

	/// <summary>
	/// Get/Set the uniform scaling factor applied to the atoms.
	/// This is ignored when AtomicRadiusType == CustomArrayRadius.
	/// Default: 0.3.
	/// </summary>
	public virtual float GetAtomicRadiusScaleFactor()
	{
		return vtkMoleculeMapper_GetAtomicRadiusScaleFactor_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMoleculeMapper_GetAtomicRadiusType_10(HandleRef pThis);

	/// <summary>
	/// Get/Set the type of radius used to generate the atoms. Default:
	/// VDWRadius. If CustomArrayRadius is used, the VertexData array named
	/// 'radii' is used for per-atom radii.
	/// </summary>
	public virtual int GetAtomicRadiusType()
	{
		return vtkMoleculeMapper_GetAtomicRadiusType_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMoleculeMapper_GetAtomicRadiusTypeAsString_11(HandleRef pThis);

	/// <summary>
	/// Get/Set the type of radius used to generate the atoms. Default:
	/// VDWRadius. If CustomArrayRadius is used, the VertexData array named
	/// 'radii' is used for per-atom radii.
	/// </summary>
	public string GetAtomicRadiusTypeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkMoleculeMapper_GetAtomicRadiusTypeAsString_11(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMoleculeMapper_GetBondColor_12(HandleRef pThis);

	/// <summary>
	/// Get/Set the color of the bonds as an rgb tuple.
	/// Default: {50, 50, 50} (dark grey)
	/// </summary>
	public virtual byte[] GetBondColor()
	{
		IntPtr intPtr = vtkMoleculeMapper_GetBondColor_12(GetCppThis());
		byte[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new byte[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_GetBondColor_13(HandleRef pThis, ref byte _arg1, ref byte _arg2, ref byte _arg3);

	/// <summary>
	/// Get/Set the color of the bonds as an rgb tuple.
	/// Default: {50, 50, 50} (dark grey)
	/// </summary>
	public virtual void GetBondColor(ref byte _arg1, ref byte _arg2, ref byte _arg3)
	{
		vtkMoleculeMapper_GetBondColor_13(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_GetBondColor_14(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the color of the bonds as an rgb tuple.
	/// Default: {50, 50, 50} (dark grey)
	/// </summary>
	public virtual void GetBondColor(IntPtr _arg)
	{
		vtkMoleculeMapper_GetBondColor_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMoleculeMapper_GetBondColorMode_15(HandleRef pThis);

	/// <summary>
	/// Get/Set the method by which bonds are colored.
	///
	/// If 'SingleColor' is used, all bonds will be the same color. Use
	/// SetBondColor to set the rgb values used.
	///
	/// If 'DiscreteByAtom' is selected, each bond is colored using the
	/// same lookup table as the atoms at each end, with a sharp color
	/// boundary at the bond center.
	/// </summary>
	public virtual int GetBondColorMode()
	{
		return vtkMoleculeMapper_GetBondColorMode_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMoleculeMapper_GetBondColorModeAsString_16(HandleRef pThis);

	/// <summary>
	/// Get/Set the method by which bonds are colored.
	///
	/// If 'SingleColor' is used, all bonds will be the same color. Use
	/// SetBondColor to set the rgb values used.
	///
	/// If 'DiscreteByAtom' is selected, each bond is colored using the
	/// same lookup table as the atoms at each end, with a sharp color
	/// boundary at the bond center.
	/// </summary>
	public string GetBondColorModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkMoleculeMapper_GetBondColorModeAsString_16(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMoleculeMapper_GetBondColorModeMaxValue_17(HandleRef pThis);

	/// <summary>
	/// Get/Set the method by which bonds are colored.
	///
	/// If 'SingleColor' is used, all bonds will be the same color. Use
	/// SetBondColor to set the rgb values used.
	///
	/// If 'DiscreteByAtom' is selected, each bond is colored using the
	/// same lookup table as the atoms at each end, with a sharp color
	/// boundary at the bond center.
	/// </summary>
	public virtual int GetBondColorModeMaxValue()
	{
		return vtkMoleculeMapper_GetBondColorModeMaxValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMoleculeMapper_GetBondColorModeMinValue_18(HandleRef pThis);

	/// <summary>
	/// Get/Set the method by which bonds are colored.
	///
	/// If 'SingleColor' is used, all bonds will be the same color. Use
	/// SetBondColor to set the rgb values used.
	///
	/// If 'DiscreteByAtom' is selected, each bond is colored using the
	/// same lookup table as the atoms at each end, with a sharp color
	/// boundary at the bond center.
	/// </summary>
	public virtual int GetBondColorModeMinValue()
	{
		return vtkMoleculeMapper_GetBondColorModeMinValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkMoleculeMapper_GetBondRadius_19(HandleRef pThis);

	/// <summary>
	/// Get/Set the radius of the bond cylinders. Default: 0.075
	/// </summary>
	public virtual float GetBondRadius()
	{
		return vtkMoleculeMapper_GetBondRadius_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMoleculeMapper_GetBounds_20(HandleRef pThis);

	/// <summary>
	/// Reimplemented from base class
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkMoleculeMapper_GetBounds_20(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_GetBounds_21(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Reimplemented from base class
	/// </summary>
	public override void GetBounds(IntPtr bounds)
	{
		vtkMoleculeMapper_GetBounds_21(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMoleculeMapper_GetInput_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the input vtkMolecule.
	/// </summary>
	public new vtkMolecule GetInput()
	{
		vtkMolecule vtkMolecule2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMoleculeMapper_GetInput_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMolecule2 = (vtkMolecule)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMolecule2.Register(null);
			}
		}
		return vtkMolecule2;
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMoleculeMapper_GetLatticeColor_23(HandleRef pThis);

	/// <summary>
	/// Get/Set the color of the bonds as an rgb tuple.
	/// Default: {255, 255, 255} (white)
	/// </summary>
	public virtual byte[] GetLatticeColor()
	{
		IntPtr intPtr = vtkMoleculeMapper_GetLatticeColor_23(GetCppThis());
		byte[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new byte[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_GetLatticeColor_24(HandleRef pThis, ref byte _arg1, ref byte _arg2, ref byte _arg3);

	/// <summary>
	/// Get/Set the color of the bonds as an rgb tuple.
	/// Default: {255, 255, 255} (white)
	/// </summary>
	public virtual void GetLatticeColor(ref byte _arg1, ref byte _arg2, ref byte _arg3)
	{
		vtkMoleculeMapper_GetLatticeColor_24(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_GetLatticeColor_25(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the color of the bonds as an rgb tuple.
	/// Default: {255, 255, 255} (white)
	/// </summary>
	public virtual void GetLatticeColor(IntPtr _arg)
	{
		vtkMoleculeMapper_GetLatticeColor_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMoleculeMapper_GetNumberOfGenerationsFromBase_26(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMoleculeMapper_GetNumberOfGenerationsFromBase_26(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMoleculeMapper_GetNumberOfGenerationsFromBaseType_27(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMoleculeMapper_GetNumberOfGenerationsFromBaseType_27(type);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMoleculeMapper_GetPeriodicTable_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Accessor to internal structure. This is exposed to make it available for ray tracers.
	/// </summary>
	public vtkPeriodicTable GetPeriodicTable()
	{
		vtkPeriodicTable vtkPeriodicTable2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMoleculeMapper_GetPeriodicTable_28(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPeriodicTable2 = (vtkPeriodicTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPeriodicTable2.Register(null);
			}
		}
		return vtkPeriodicTable2;
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMoleculeMapper_GetRenderAtoms_29(HandleRef pThis);

	/// <summary>
	/// Get/Set whether or not to render atoms. Default: On.
	/// </summary>
	public virtual bool GetRenderAtoms()
	{
		return (vtkMoleculeMapper_GetRenderAtoms_29(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMoleculeMapper_GetRenderBonds_30(HandleRef pThis);

	/// <summary>
	/// Get/Set whether or not to render bonds. Default: On.
	/// </summary>
	public virtual bool GetRenderBonds()
	{
		return (vtkMoleculeMapper_GetRenderBonds_30(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMoleculeMapper_GetRenderLattice_31(HandleRef pThis);

	/// <summary>
	/// Get/Set whether or not to render the unit cell lattice, if present.
	/// Default: On.
	/// </summary>
	public virtual bool GetRenderLattice()
	{
		return (vtkMoleculeMapper_GetRenderLattice_31(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_GetSelectedAtoms_32(HandleRef pThis, HandleRef selection, HandleRef atomIds);

	/// <summary>
	/// Extract the ids atoms and/or bonds rendered by this molecule from a
	/// vtkSelection object. The vtkIdTypeArray
	/// </summary>
	public virtual void GetSelectedAtoms(vtkSelection selection, vtkIdTypeArray atomIds)
	{
		vtkMoleculeMapper_GetSelectedAtoms_32(GetCppThis(), selection?.GetCppThis() ?? default(HandleRef), atomIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_GetSelectedAtomsAndBonds_33(HandleRef pThis, HandleRef selection, HandleRef atomIds, HandleRef bondIds);

	/// <summary>
	/// Extract the ids atoms and/or bonds rendered by this molecule from a
	/// vtkSelection object. The vtkIdTypeArray
	/// </summary>
	public virtual void GetSelectedAtomsAndBonds(vtkSelection selection, vtkIdTypeArray atomIds, vtkIdTypeArray bondIds)
	{
		vtkMoleculeMapper_GetSelectedAtomsAndBonds_33(GetCppThis(), selection?.GetCppThis() ?? default(HandleRef), atomIds?.GetCppThis() ?? default(HandleRef), bondIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_GetSelectedBonds_34(HandleRef pThis, HandleRef selection, HandleRef bondIds);

	/// <summary>
	/// Extract the ids atoms and/or bonds rendered by this molecule from a
	/// vtkSelection object. The vtkIdTypeArray
	/// </summary>
	public virtual void GetSelectedBonds(vtkSelection selection, vtkIdTypeArray bondIds)
	{
		vtkMoleculeMapper_GetSelectedBonds_34(GetCppThis(), selection?.GetCppThis() ?? default(HandleRef), bondIds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMoleculeMapper_GetSupportsSelection_35(HandleRef pThis);

	/// <summary>
	/// Reimplemented from base class
	/// </summary>
	public override bool GetSupportsSelection()
	{
		return (vtkMoleculeMapper_GetSupportsSelection_35(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMoleculeMapper_GetUseMultiCylindersForBonds_36(HandleRef pThis);

	/// <summary>
	/// Get/Set whether multicylinders will be used to represent multiple
	/// bonds. Default: On.
	/// </summary>
	public virtual bool GetUseMultiCylindersForBonds()
	{
		return (vtkMoleculeMapper_GetUseMultiCylindersForBonds_36(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMoleculeMapper_IsA_37(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMoleculeMapper_IsA_37(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMoleculeMapper_IsTypeOf_38(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMoleculeMapper_IsTypeOf_38(type);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMoleculeMapper_NewInstance_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMoleculeMapper NewInstance()
	{
		vtkMoleculeMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMoleculeMapper_NewInstance_40(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMoleculeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_ReleaseGraphicsResources_41(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Reimplemented from base class
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkMoleculeMapper_ReleaseGraphicsResources_41(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_Render_42(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// Reimplemented from base class
	/// </summary>
	public override void Render(vtkRenderer arg0, vtkActor arg1)
	{
		vtkMoleculeMapper_Render_42(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_RenderAtomsOff_43(HandleRef pThis);

	/// <summary>
	/// Get/Set whether or not to render atoms. Default: On.
	/// </summary>
	public virtual void RenderAtomsOff()
	{
		vtkMoleculeMapper_RenderAtomsOff_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_RenderAtomsOn_44(HandleRef pThis);

	/// <summary>
	/// Get/Set whether or not to render atoms. Default: On.
	/// </summary>
	public virtual void RenderAtomsOn()
	{
		vtkMoleculeMapper_RenderAtomsOn_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_RenderBondsOff_45(HandleRef pThis);

	/// <summary>
	/// Get/Set whether or not to render bonds. Default: On.
	/// </summary>
	public virtual void RenderBondsOff()
	{
		vtkMoleculeMapper_RenderBondsOff_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_RenderBondsOn_46(HandleRef pThis);

	/// <summary>
	/// Get/Set whether or not to render bonds. Default: On.
	/// </summary>
	public virtual void RenderBondsOn()
	{
		vtkMoleculeMapper_RenderBondsOn_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_RenderLatticeOff_47(HandleRef pThis);

	/// <summary>
	/// Get/Set whether or not to render the unit cell lattice, if present.
	/// Default: On.
	/// </summary>
	public virtual void RenderLatticeOff()
	{
		vtkMoleculeMapper_RenderLatticeOff_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_RenderLatticeOn_48(HandleRef pThis);

	/// <summary>
	/// Get/Set whether or not to render the unit cell lattice, if present.
	/// Default: On.
	/// </summary>
	public virtual void RenderLatticeOn()
	{
		vtkMoleculeMapper_RenderLatticeOn_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMoleculeMapper_SafeDownCast_49(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMoleculeMapper SafeDownCast(vtkObjectBase o)
	{
		vtkMoleculeMapper vtkMoleculeMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMoleculeMapper_SafeDownCast_49(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMoleculeMapper2 = (vtkMoleculeMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMoleculeMapper2.Register(null);
			}
		}
		return vtkMoleculeMapper2;
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_SetAtomColor_50(HandleRef pThis, byte _arg1, byte _arg2, byte _arg3);

	/// <summary>
	/// Get/Set the color of the atoms as an rgb tuple.
	/// Default: {150, 150, 150} (grey)
	/// </summary>
	public virtual void SetAtomColor(byte _arg1, byte _arg2, byte _arg3)
	{
		vtkMoleculeMapper_SetAtomColor_50(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_SetAtomColor_51(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the color of the atoms as an rgb tuple.
	/// Default: {150, 150, 150} (grey)
	/// </summary>
	public virtual void SetAtomColor(IntPtr _arg)
	{
		vtkMoleculeMapper_SetAtomColor_51(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_SetAtomColorMode_52(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the method by which atoms are colored.
	///
	/// If 'SingleColor' is used, all atoms will have the same color. Use
	/// SetAtomColor to set the rgb values to be used.
	///
	/// If 'DiscreteByAtom' is selected, each atom is colored using the
	/// internal lookup table.
	/// </summary>
	public virtual void SetAtomColorMode(int _arg)
	{
		vtkMoleculeMapper_SetAtomColorMode_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_SetAtomicRadiusArrayName_53(HandleRef pThis, string _arg);

	/// <summary>
	/// Get/Set the atomic radius array name. Default: "radii"
	/// It is only used when AtomicRadiusType is set to CustomArrayRadius.
	/// </summary>
	public virtual void SetAtomicRadiusArrayName(string _arg)
	{
		vtkMoleculeMapper_SetAtomicRadiusArrayName_53(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_SetAtomicRadiusScaleFactor_54(HandleRef pThis, float _arg);

	/// <summary>
	/// Get/Set the uniform scaling factor applied to the atoms.
	/// This is ignored when AtomicRadiusType == CustomArrayRadius.
	/// Default: 0.3.
	/// </summary>
	public virtual void SetAtomicRadiusScaleFactor(float _arg)
	{
		vtkMoleculeMapper_SetAtomicRadiusScaleFactor_54(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_SetAtomicRadiusType_55(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the type of radius used to generate the atoms. Default:
	/// VDWRadius. If CustomArrayRadius is used, the VertexData array named
	/// 'radii' is used for per-atom radii.
	/// </summary>
	public virtual void SetAtomicRadiusType(int _arg)
	{
		vtkMoleculeMapper_SetAtomicRadiusType_55(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_SetAtomicRadiusTypeToCovalentRadius_56(HandleRef pThis);

	/// <summary>
	/// Get/Set the type of radius used to generate the atoms. Default:
	/// VDWRadius. If CustomArrayRadius is used, the VertexData array named
	/// 'radii' is used for per-atom radii.
	/// </summary>
	public void SetAtomicRadiusTypeToCovalentRadius()
	{
		vtkMoleculeMapper_SetAtomicRadiusTypeToCovalentRadius_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_SetAtomicRadiusTypeToCustomArrayRadius_57(HandleRef pThis);

	/// <summary>
	/// Get/Set the type of radius used to generate the atoms. Default:
	/// VDWRadius. If CustomArrayRadius is used, the VertexData array named
	/// 'radii' is used for per-atom radii.
	/// </summary>
	public void SetAtomicRadiusTypeToCustomArrayRadius()
	{
		vtkMoleculeMapper_SetAtomicRadiusTypeToCustomArrayRadius_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_SetAtomicRadiusTypeToUnitRadius_58(HandleRef pThis);

	/// <summary>
	/// Get/Set the type of radius used to generate the atoms. Default:
	/// VDWRadius. If CustomArrayRadius is used, the VertexData array named
	/// 'radii' is used for per-atom radii.
	/// </summary>
	public void SetAtomicRadiusTypeToUnitRadius()
	{
		vtkMoleculeMapper_SetAtomicRadiusTypeToUnitRadius_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_SetAtomicRadiusTypeToVDWRadius_59(HandleRef pThis);

	/// <summary>
	/// Get/Set the type of radius used to generate the atoms. Default:
	/// VDWRadius. If CustomArrayRadius is used, the VertexData array named
	/// 'radii' is used for per-atom radii.
	/// </summary>
	public void SetAtomicRadiusTypeToVDWRadius()
	{
		vtkMoleculeMapper_SetAtomicRadiusTypeToVDWRadius_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_SetBondColor_60(HandleRef pThis, byte _arg1, byte _arg2, byte _arg3);

	/// <summary>
	/// Get/Set the color of the bonds as an rgb tuple.
	/// Default: {50, 50, 50} (dark grey)
	/// </summary>
	public virtual void SetBondColor(byte _arg1, byte _arg2, byte _arg3)
	{
		vtkMoleculeMapper_SetBondColor_60(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_SetBondColor_61(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the color of the bonds as an rgb tuple.
	/// Default: {50, 50, 50} (dark grey)
	/// </summary>
	public virtual void SetBondColor(IntPtr _arg)
	{
		vtkMoleculeMapper_SetBondColor_61(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_SetBondColorMode_62(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the method by which bonds are colored.
	///
	/// If 'SingleColor' is used, all bonds will be the same color. Use
	/// SetBondColor to set the rgb values used.
	///
	/// If 'DiscreteByAtom' is selected, each bond is colored using the
	/// same lookup table as the atoms at each end, with a sharp color
	/// boundary at the bond center.
	/// </summary>
	public virtual void SetBondColorMode(int _arg)
	{
		vtkMoleculeMapper_SetBondColorMode_62(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_SetBondColorModeToDiscreteByAtom_63(HandleRef pThis);

	/// <summary>
	/// Get/Set the method by which bonds are colored.
	///
	/// If 'SingleColor' is used, all bonds will be the same color. Use
	/// SetBondColor to set the rgb values used.
	///
	/// If 'DiscreteByAtom' is selected, each bond is colored using the
	/// same lookup table as the atoms at each end, with a sharp color
	/// boundary at the bond center.
	/// </summary>
	public void SetBondColorModeToDiscreteByAtom()
	{
		vtkMoleculeMapper_SetBondColorModeToDiscreteByAtom_63(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_SetBondColorModeToSingleColor_64(HandleRef pThis);

	/// <summary>
	/// Get/Set the method by which bonds are colored.
	///
	/// If 'SingleColor' is used, all bonds will be the same color. Use
	/// SetBondColor to set the rgb values used.
	///
	/// If 'DiscreteByAtom' is selected, each bond is colored using the
	/// same lookup table as the atoms at each end, with a sharp color
	/// boundary at the bond center.
	/// </summary>
	public void SetBondColorModeToSingleColor()
	{
		vtkMoleculeMapper_SetBondColorModeToSingleColor_64(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_SetBondRadius_65(HandleRef pThis, float _arg);

	/// <summary>
	/// Get/Set the radius of the bond cylinders. Default: 0.075
	/// </summary>
	public virtual void SetBondRadius(float _arg)
	{
		vtkMoleculeMapper_SetBondRadius_65(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_SetInputData_66(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get/Set the input vtkMolecule.
	/// </summary>
	public void SetInputData(vtkMolecule arg0)
	{
		vtkMoleculeMapper_SetInputData_66(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_SetLatticeColor_67(HandleRef pThis, byte _arg1, byte _arg2, byte _arg3);

	/// <summary>
	/// Get/Set the color of the bonds as an rgb tuple.
	/// Default: {255, 255, 255} (white)
	/// </summary>
	public virtual void SetLatticeColor(byte _arg1, byte _arg2, byte _arg3)
	{
		vtkMoleculeMapper_SetLatticeColor_67(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_SetLatticeColor_68(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the color of the bonds as an rgb tuple.
	/// Default: {255, 255, 255} (white)
	/// </summary>
	public virtual void SetLatticeColor(IntPtr _arg)
	{
		vtkMoleculeMapper_SetLatticeColor_68(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_SetMapScalars_69(HandleRef pThis, byte map);

	/// <summary>
	/// Helper method to set ScalarMode on both AtomGlyphMapper and BondGlyphMapper.
	/// true means VTK_COLOR_MODE_MAP_SCALARS, false VTK_COLOR_MODE_DIRECT_SCALARS.
	/// </summary>
	public virtual void SetMapScalars(bool map)
	{
		vtkMoleculeMapper_SetMapScalars_69(GetCppThis(), (byte)(map ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_SetRenderAtoms_70(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/Set whether or not to render atoms. Default: On.
	/// </summary>
	public virtual void SetRenderAtoms(bool _arg)
	{
		vtkMoleculeMapper_SetRenderAtoms_70(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_SetRenderBonds_71(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/Set whether or not to render bonds. Default: On.
	/// </summary>
	public virtual void SetRenderBonds(bool _arg)
	{
		vtkMoleculeMapper_SetRenderBonds_71(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_SetRenderLattice_72(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/Set whether or not to render the unit cell lattice, if present.
	/// Default: On.
	/// </summary>
	public virtual void SetRenderLattice(bool _arg)
	{
		vtkMoleculeMapper_SetRenderLattice_72(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_SetUseMultiCylindersForBonds_73(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/Set whether multicylinders will be used to represent multiple
	/// bonds. Default: On.
	/// </summary>
	public virtual void SetUseMultiCylindersForBonds(bool _arg)
	{
		vtkMoleculeMapper_SetUseMultiCylindersForBonds_73(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_UseBallAndStickSettings_74(HandleRef pThis);

	/// <summary>
	/// Set ivars to default ball-and-stick settings. This is equivalent
	/// to the following:
	/// - SetRenderAtoms( true )
	/// - SetRenderBonds( true )
	/// - SetAtomicRadiusType( VDWRadius )
	/// - SetAtomicRadiusScaleFactor( 0.3 )
	/// - SetBondColorMode( DiscreteByAtom )
	/// - SetUseMultiCylindersForBonds( true )
	/// - SetBondRadius( 0.075 )
	/// </summary>
	public void UseBallAndStickSettings()
	{
		vtkMoleculeMapper_UseBallAndStickSettings_74(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_UseFastSettings_75(HandleRef pThis);

	/// <summary>
	/// Set ivars to use fast settings that may be useful for rendering
	/// extremely large molecules where the overall shape is more
	/// important than the details of the atoms/bond. This is equivalent
	/// to the following:
	/// - SetRenderAtoms( true )
	/// - SetRenderBonds( true )
	/// - SetAtomicRadiusType( UnitRadius )
	/// - SetAtomicRadiusScaleFactor( 0.60 )
	/// - SetBondColorMode( SingleColor )
	/// - SetBondColor( 50, 50, 50 )
	/// - SetUseMultiCylindersForBonds( false )
	/// - SetBondRadius( 0.075 )
	/// </summary>
	public void UseFastSettings()
	{
		vtkMoleculeMapper_UseFastSettings_75(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_UseLiquoriceStickSettings_76(HandleRef pThis);

	/// <summary>
	/// Set ivars to default liquorice stick settings. This is
	/// equivalent to the following:
	/// - SetRenderAtoms( true )
	/// - SetRenderBonds( true )
	/// - SetAtomicRadiusType( UnitRadius )
	/// - SetAtomicRadiusScaleFactor( 0.1 )
	/// - SetBondColorMode( DiscreteByAtom )
	/// - SetUseMultiCylindersForBonds( false )
	/// - SetBondRadius( 0.1 )
	/// </summary>
	public void UseLiquoriceStickSettings()
	{
		vtkMoleculeMapper_UseLiquoriceStickSettings_76(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_UseMultiCylindersForBondsOff_77(HandleRef pThis);

	/// <summary>
	/// Get/Set whether multicylinders will be used to represent multiple
	/// bonds. Default: On.
	/// </summary>
	public virtual void UseMultiCylindersForBondsOff()
	{
		vtkMoleculeMapper_UseMultiCylindersForBondsOff_77(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_UseMultiCylindersForBondsOn_78(HandleRef pThis);

	/// <summary>
	/// Get/Set whether multicylinders will be used to represent multiple
	/// bonds. Default: On.
	/// </summary>
	public virtual void UseMultiCylindersForBondsOn()
	{
		vtkMoleculeMapper_UseMultiCylindersForBondsOn_78(GetCppThis());
	}

	[DllImport("Kitware.VTK.DomainsChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMoleculeMapper_UseVDWSpheresSettings_79(HandleRef pThis);

	/// <summary>
	/// Set ivars to default van der Waals spheres settings. This is
	/// equivalent to the following:
	/// - SetRenderAtoms( true )
	/// - SetRenderBonds( true )
	/// - SetAtomicRadiusType( VDWRadius )
	/// - SetAtomicRadiusScaleFactor( 1.0 )
	/// - SetBondColorMode( DiscreteByAtom )
	/// - SetUseMultiCylindersForBonds( true )
	/// - SetBondRadius( 0.075 )
	/// </summary>
	public void UseVDWSpheresSettings()
	{
		vtkMoleculeMapper_UseVDWSpheresSettings_79(GetCppThis());
	}
}
