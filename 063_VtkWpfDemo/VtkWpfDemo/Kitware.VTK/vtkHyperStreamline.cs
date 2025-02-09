using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkHyperStreamline
/// </summary>
/// <remarks>
///    generate hyperstreamline in arbitrary dataset
///
/// vtkHyperStreamline is a filter that integrates through a tensor field to
/// generate a hyperstreamline. The integration is along the maximum eigenvector
/// and the cross section of the hyperstreamline is defined by the two other
/// eigenvectors. Thus the shape of the hyperstreamline is "tube-like", with
/// the cross section being elliptical. Hyperstreamlines are used to visualize
/// tensor fields.
///
/// The starting point of a hyperstreamline can be defined in one of two ways.
/// First, you may specify an initial position. This is a x-y-z global
/// coordinate. The second option is to specify a starting location. This is
/// cellId, subId, and cell parametric coordinates.
///
/// The integration of the hyperstreamline occurs through the major eigenvector
/// field. IntegrationStepLength controls the step length within each cell
/// (i.e., this is the fraction of the cell length). The length of the
/// hyperstreamline is controlled by MaximumPropagationDistance. This parameter
/// is the length of the hyperstreamline in units of distance. The tube itself
/// is composed of many small sub-tubes - NumberOfSides controls the number of
/// sides in the tube, and StepLength controls the length of the sub-tubes.
///
/// Because hyperstreamlines are often created near regions of singularities, it
/// is possible to control the scaling of the tube cross section by using a
/// logarithmic scale. Use LogScalingOn to turn this capability on. The Radius
/// value controls the initial radius of the tube.
///
/// </remarks>
/// <seealso>
///
/// vtkTensorGlyph
/// </seealso>
public class vtkHyperStreamline : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkHyperStreamline";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkHyperStreamline()
	{
		MRClassNameKey = "class vtkHyperStreamline";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkHyperStreamline"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkHyperStreamline(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperStreamline_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with initial starting position (0,0,0); integration
	/// step length 0.2; step length 0.01; forward integration; terminal
	/// eigenvalue 0.0; number of sides 6; radius 0.5; and logarithmic scaling
	/// off.
	/// </summary>
	public new static vtkHyperStreamline New()
	{
		vtkHyperStreamline result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHyperStreamline_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHyperStreamline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with initial starting position (0,0,0); integration
	/// step length 0.2; step length 0.01; forward integration; terminal
	/// eigenvalue 0.0; number of sides 6; radius 0.5; and logarithmic scaling
	/// off.
	/// </summary>
	public vtkHyperStreamline()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkHyperStreamline_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperStreamline_GetIntegrationDirection_01(HandleRef pThis);

	/// <summary>
	/// Specify the direction in which to integrate the hyperstreamline.
	/// </summary>
	public virtual int GetIntegrationDirection()
	{
		return vtkHyperStreamline_GetIntegrationDirection_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperStreamline_GetIntegrationDirectionMaxValue_02(HandleRef pThis);

	/// <summary>
	/// Specify the direction in which to integrate the hyperstreamline.
	/// </summary>
	public virtual int GetIntegrationDirectionMaxValue()
	{
		return vtkHyperStreamline_GetIntegrationDirectionMaxValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperStreamline_GetIntegrationDirectionMinValue_03(HandleRef pThis);

	/// <summary>
	/// Specify the direction in which to integrate the hyperstreamline.
	/// </summary>
	public virtual int GetIntegrationDirectionMinValue()
	{
		return vtkHyperStreamline_GetIntegrationDirectionMinValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperStreamline_GetIntegrationEigenvector_04(HandleRef pThis);

	/// <summary>
	/// Set / get the eigenvector field through which to ingrate. It is
	/// possible to integrate using the major, medium or minor
	/// eigenvector field.  The major eigenvector is the eigenvector
	/// whose corresponding eigenvalue is closest to positive infinity.
	/// The minor eigenvector is the eigenvector whose corresponding
	/// eigenvalue is closest to negative infinity.  The medium
	/// eigenvector is the eigenvector whose corresponding eigenvalue is
	/// between the major and minor eigenvalues.
	/// </summary>
	public virtual int GetIntegrationEigenvector()
	{
		return vtkHyperStreamline_GetIntegrationEigenvector_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperStreamline_GetIntegrationEigenvectorMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Set / get the eigenvector field through which to ingrate. It is
	/// possible to integrate using the major, medium or minor
	/// eigenvector field.  The major eigenvector is the eigenvector
	/// whose corresponding eigenvalue is closest to positive infinity.
	/// The minor eigenvector is the eigenvector whose corresponding
	/// eigenvalue is closest to negative infinity.  The medium
	/// eigenvector is the eigenvector whose corresponding eigenvalue is
	/// between the major and minor eigenvalues.
	/// </summary>
	public virtual int GetIntegrationEigenvectorMaxValue()
	{
		return vtkHyperStreamline_GetIntegrationEigenvectorMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperStreamline_GetIntegrationEigenvectorMinValue_06(HandleRef pThis);

	/// <summary>
	/// Set / get the eigenvector field through which to ingrate. It is
	/// possible to integrate using the major, medium or minor
	/// eigenvector field.  The major eigenvector is the eigenvector
	/// whose corresponding eigenvalue is closest to positive infinity.
	/// The minor eigenvector is the eigenvector whose corresponding
	/// eigenvalue is closest to negative infinity.  The medium
	/// eigenvector is the eigenvector whose corresponding eigenvalue is
	/// between the major and minor eigenvalues.
	/// </summary>
	public virtual int GetIntegrationEigenvectorMinValue()
	{
		return vtkHyperStreamline_GetIntegrationEigenvectorMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkHyperStreamline_GetIntegrationStepLength_07(HandleRef pThis);

	/// <summary>
	/// Set / get a nominal integration step size (expressed as a fraction of
	/// the size of each cell).
	/// </summary>
	public virtual double GetIntegrationStepLength()
	{
		return vtkHyperStreamline_GetIntegrationStepLength_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkHyperStreamline_GetIntegrationStepLengthMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Set / get a nominal integration step size (expressed as a fraction of
	/// the size of each cell).
	/// </summary>
	public virtual double GetIntegrationStepLengthMaxValue()
	{
		return vtkHyperStreamline_GetIntegrationStepLengthMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkHyperStreamline_GetIntegrationStepLengthMinValue_09(HandleRef pThis);

	/// <summary>
	/// Set / get a nominal integration step size (expressed as a fraction of
	/// the size of each cell).
	/// </summary>
	public virtual double GetIntegrationStepLengthMinValue()
	{
		return vtkHyperStreamline_GetIntegrationStepLengthMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperStreamline_GetLogScaling_10(HandleRef pThis);

	/// <summary>
	/// Turn on/off logarithmic scaling. If scaling is on, the log base 10
	/// of the computed eigenvalues are used to scale the cross section radii.
	/// </summary>
	public virtual int GetLogScaling()
	{
		return vtkHyperStreamline_GetLogScaling_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkHyperStreamline_GetMaximumPropagationDistance_11(HandleRef pThis);

	/// <summary>
	/// Set / get the maximum length of the hyperstreamline expressed as absolute
	/// distance (i.e., arc length) value.
	/// </summary>
	public virtual double GetMaximumPropagationDistance()
	{
		return vtkHyperStreamline_GetMaximumPropagationDistance_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkHyperStreamline_GetMaximumPropagationDistanceMaxValue_12(HandleRef pThis);

	/// <summary>
	/// Set / get the maximum length of the hyperstreamline expressed as absolute
	/// distance (i.e., arc length) value.
	/// </summary>
	public virtual double GetMaximumPropagationDistanceMaxValue()
	{
		return vtkHyperStreamline_GetMaximumPropagationDistanceMaxValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkHyperStreamline_GetMaximumPropagationDistanceMinValue_13(HandleRef pThis);

	/// <summary>
	/// Set / get the maximum length of the hyperstreamline expressed as absolute
	/// distance (i.e., arc length) value.
	/// </summary>
	public virtual double GetMaximumPropagationDistanceMinValue()
	{
		return vtkHyperStreamline_GetMaximumPropagationDistanceMinValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHyperStreamline_GetNumberOfGenerationsFromBase_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkHyperStreamline_GetNumberOfGenerationsFromBase_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHyperStreamline_GetNumberOfGenerationsFromBaseType_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkHyperStreamline_GetNumberOfGenerationsFromBaseType_15(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperStreamline_GetNumberOfSides_16(HandleRef pThis);

	/// <summary>
	/// Set / get the number of sides for the hyperstreamlines. At a minimum,
	/// number of sides is 3.
	/// </summary>
	public virtual int GetNumberOfSides()
	{
		return vtkHyperStreamline_GetNumberOfSides_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperStreamline_GetNumberOfSidesMaxValue_17(HandleRef pThis);

	/// <summary>
	/// Set / get the number of sides for the hyperstreamlines. At a minimum,
	/// number of sides is 3.
	/// </summary>
	public virtual int GetNumberOfSidesMaxValue()
	{
		return vtkHyperStreamline_GetNumberOfSidesMaxValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperStreamline_GetNumberOfSidesMinValue_18(HandleRef pThis);

	/// <summary>
	/// Set / get the number of sides for the hyperstreamlines. At a minimum,
	/// number of sides is 3.
	/// </summary>
	public virtual int GetNumberOfSidesMinValue()
	{
		return vtkHyperStreamline_GetNumberOfSidesMinValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkHyperStreamline_GetRadius_19(HandleRef pThis);

	/// <summary>
	/// Set / get the initial tube radius. This is the maximum "elliptical"
	/// radius at the beginning of the tube. Radius varies based on ratio of
	/// eigenvalues.  Note that tube section is actually elliptical and may
	/// become a point or line in cross section in some cases.
	/// </summary>
	public virtual double GetRadius()
	{
		return vtkHyperStreamline_GetRadius_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkHyperStreamline_GetRadiusMaxValue_20(HandleRef pThis);

	/// <summary>
	/// Set / get the initial tube radius. This is the maximum "elliptical"
	/// radius at the beginning of the tube. Radius varies based on ratio of
	/// eigenvalues.  Note that tube section is actually elliptical and may
	/// become a point or line in cross section in some cases.
	/// </summary>
	public virtual double GetRadiusMaxValue()
	{
		return vtkHyperStreamline_GetRadiusMaxValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkHyperStreamline_GetRadiusMinValue_21(HandleRef pThis);

	/// <summary>
	/// Set / get the initial tube radius. This is the maximum "elliptical"
	/// radius at the beginning of the tube. Radius varies based on ratio of
	/// eigenvalues.  Note that tube section is actually elliptical and may
	/// become a point or line in cross section in some cases.
	/// </summary>
	public virtual double GetRadiusMinValue()
	{
		return vtkHyperStreamline_GetRadiusMinValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkHyperStreamline_GetStartLocation_22(HandleRef pThis, ref int subId, IntPtr pcoords);

	/// <summary>
	/// Get the starting location of the hyperstreamline in the cell coordinate
	/// system. Returns the cell that the starting point is in.
	/// </summary>
	public long GetStartLocation(ref int subId, IntPtr pcoords)
	{
		return vtkHyperStreamline_GetStartLocation_22(GetCppThis(), ref subId, pcoords);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperStreamline_GetStartPosition_23(HandleRef pThis);

	/// <summary>
	/// Get the start position of the hyperstreamline in global x-y-z coordinates.
	/// </summary>
	public double[] GetStartPosition()
	{
		IntPtr intPtr = vtkHyperStreamline_GetStartPosition_23(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkHyperStreamline_GetStepLength_24(HandleRef pThis);

	/// <summary>
	/// Set / get the length of a tube segment composing the
	/// hyperstreamline. The length is specified as a fraction of the
	/// diagonal length of the input bounding box.
	/// </summary>
	public virtual double GetStepLength()
	{
		return vtkHyperStreamline_GetStepLength_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkHyperStreamline_GetStepLengthMaxValue_25(HandleRef pThis);

	/// <summary>
	/// Set / get the length of a tube segment composing the
	/// hyperstreamline. The length is specified as a fraction of the
	/// diagonal length of the input bounding box.
	/// </summary>
	public virtual double GetStepLengthMaxValue()
	{
		return vtkHyperStreamline_GetStepLengthMaxValue_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkHyperStreamline_GetStepLengthMinValue_26(HandleRef pThis);

	/// <summary>
	/// Set / get the length of a tube segment composing the
	/// hyperstreamline. The length is specified as a fraction of the
	/// diagonal length of the input bounding box.
	/// </summary>
	public virtual double GetStepLengthMinValue()
	{
		return vtkHyperStreamline_GetStepLengthMinValue_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkHyperStreamline_GetTerminalEigenvalue_27(HandleRef pThis);

	/// <summary>
	/// Set/get terminal eigenvalue.  If major eigenvalue falls below this
	/// value, hyperstreamline terminates propagation.
	/// </summary>
	public virtual double GetTerminalEigenvalue()
	{
		return vtkHyperStreamline_GetTerminalEigenvalue_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkHyperStreamline_GetTerminalEigenvalueMaxValue_28(HandleRef pThis);

	/// <summary>
	/// Set/get terminal eigenvalue.  If major eigenvalue falls below this
	/// value, hyperstreamline terminates propagation.
	/// </summary>
	public virtual double GetTerminalEigenvalueMaxValue()
	{
		return vtkHyperStreamline_GetTerminalEigenvalueMaxValue_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkHyperStreamline_GetTerminalEigenvalueMinValue_29(HandleRef pThis);

	/// <summary>
	/// Set/get terminal eigenvalue.  If major eigenvalue falls below this
	/// value, hyperstreamline terminates propagation.
	/// </summary>
	public virtual double GetTerminalEigenvalueMinValue()
	{
		return vtkHyperStreamline_GetTerminalEigenvalueMinValue_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperStreamline_IntegrateMajorEigenvector_30(HandleRef pThis);

	/// <summary>
	/// Use the major eigenvector field as the vector field through which
	/// to integrate.  The major eigenvector is the eigenvector whose
	/// corresponding eigenvalue is closest to positive infinity.
	/// </summary>
	public void IntegrateMajorEigenvector()
	{
		vtkHyperStreamline_IntegrateMajorEigenvector_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperStreamline_IntegrateMediumEigenvector_31(HandleRef pThis);

	/// <summary>
	/// Use the medium eigenvector field as the vector field through which
	/// to integrate. The medium eigenvector is the eigenvector whose
	/// corresponding eigenvalue is between the major and minor
	/// eigenvalues.
	/// </summary>
	public void IntegrateMediumEigenvector()
	{
		vtkHyperStreamline_IntegrateMediumEigenvector_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperStreamline_IntegrateMinorEigenvector_32(HandleRef pThis);

	/// <summary>
	/// Use the minor eigenvector field as the vector field through which
	/// to integrate. The minor eigenvector is the eigenvector whose
	/// corresponding eigenvalue is closest to negative infinity.
	/// </summary>
	public void IntegrateMinorEigenvector()
	{
		vtkHyperStreamline_IntegrateMinorEigenvector_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperStreamline_IsA_33(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkHyperStreamline_IsA_33(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkHyperStreamline_IsTypeOf_34(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkHyperStreamline_IsTypeOf_34(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperStreamline_LogScalingOff_35(HandleRef pThis);

	/// <summary>
	/// Turn on/off logarithmic scaling. If scaling is on, the log base 10
	/// of the computed eigenvalues are used to scale the cross section radii.
	/// </summary>
	public virtual void LogScalingOff()
	{
		vtkHyperStreamline_LogScalingOff_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperStreamline_LogScalingOn_36(HandleRef pThis);

	/// <summary>
	/// Turn on/off logarithmic scaling. If scaling is on, the log base 10
	/// of the computed eigenvalues are used to scale the cross section radii.
	/// </summary>
	public virtual void LogScalingOn()
	{
		vtkHyperStreamline_LogScalingOn_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperStreamline_NewInstance_38(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkHyperStreamline NewInstance()
	{
		vtkHyperStreamline result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHyperStreamline_NewInstance_38(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkHyperStreamline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkHyperStreamline_SafeDownCast_39(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkHyperStreamline SafeDownCast(vtkObjectBase o)
	{
		vtkHyperStreamline vtkHyperStreamline2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkHyperStreamline_SafeDownCast_39(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkHyperStreamline2 = (vtkHyperStreamline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkHyperStreamline2.Register(null);
			}
		}
		return vtkHyperStreamline2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperStreamline_SetIntegrationDirection_40(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the direction in which to integrate the hyperstreamline.
	/// </summary>
	public virtual void SetIntegrationDirection(int _arg)
	{
		vtkHyperStreamline_SetIntegrationDirection_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperStreamline_SetIntegrationDirectionToBackward_41(HandleRef pThis);

	/// <summary>
	/// Specify the direction in which to integrate the hyperstreamline.
	/// </summary>
	public void SetIntegrationDirectionToBackward()
	{
		vtkHyperStreamline_SetIntegrationDirectionToBackward_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperStreamline_SetIntegrationDirectionToForward_42(HandleRef pThis);

	/// <summary>
	/// Specify the direction in which to integrate the hyperstreamline.
	/// </summary>
	public void SetIntegrationDirectionToForward()
	{
		vtkHyperStreamline_SetIntegrationDirectionToForward_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperStreamline_SetIntegrationDirectionToIntegrateBothDirections_43(HandleRef pThis);

	/// <summary>
	/// Specify the direction in which to integrate the hyperstreamline.
	/// </summary>
	public void SetIntegrationDirectionToIntegrateBothDirections()
	{
		vtkHyperStreamline_SetIntegrationDirectionToIntegrateBothDirections_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperStreamline_SetIntegrationEigenvector_44(HandleRef pThis, int _arg);

	/// <summary>
	/// Set / get the eigenvector field through which to ingrate. It is
	/// possible to integrate using the major, medium or minor
	/// eigenvector field.  The major eigenvector is the eigenvector
	/// whose corresponding eigenvalue is closest to positive infinity.
	/// The minor eigenvector is the eigenvector whose corresponding
	/// eigenvalue is closest to negative infinity.  The medium
	/// eigenvector is the eigenvector whose corresponding eigenvalue is
	/// between the major and minor eigenvalues.
	/// </summary>
	public virtual void SetIntegrationEigenvector(int _arg)
	{
		vtkHyperStreamline_SetIntegrationEigenvector_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperStreamline_SetIntegrationEigenvectorToMajor_45(HandleRef pThis);

	/// <summary>
	/// Set / get the eigenvector field through which to ingrate. It is
	/// possible to integrate using the major, medium or minor
	/// eigenvector field.  The major eigenvector is the eigenvector
	/// whose corresponding eigenvalue is closest to positive infinity.
	/// The minor eigenvector is the eigenvector whose corresponding
	/// eigenvalue is closest to negative infinity.  The medium
	/// eigenvector is the eigenvector whose corresponding eigenvalue is
	/// between the major and minor eigenvalues.
	/// </summary>
	public void SetIntegrationEigenvectorToMajor()
	{
		vtkHyperStreamline_SetIntegrationEigenvectorToMajor_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperStreamline_SetIntegrationEigenvectorToMedium_46(HandleRef pThis);

	/// <summary>
	/// Set / get the eigenvector field through which to ingrate. It is
	/// possible to integrate using the major, medium or minor
	/// eigenvector field.  The major eigenvector is the eigenvector
	/// whose corresponding eigenvalue is closest to positive infinity.
	/// The minor eigenvector is the eigenvector whose corresponding
	/// eigenvalue is closest to negative infinity.  The medium
	/// eigenvector is the eigenvector whose corresponding eigenvalue is
	/// between the major and minor eigenvalues.
	/// </summary>
	public void SetIntegrationEigenvectorToMedium()
	{
		vtkHyperStreamline_SetIntegrationEigenvectorToMedium_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperStreamline_SetIntegrationEigenvectorToMinor_47(HandleRef pThis);

	/// <summary>
	/// Set / get the eigenvector field through which to ingrate. It is
	/// possible to integrate using the major, medium or minor
	/// eigenvector field.  The major eigenvector is the eigenvector
	/// whose corresponding eigenvalue is closest to positive infinity.
	/// The minor eigenvector is the eigenvector whose corresponding
	/// eigenvalue is closest to negative infinity.  The medium
	/// eigenvector is the eigenvector whose corresponding eigenvalue is
	/// between the major and minor eigenvalues.
	/// </summary>
	public void SetIntegrationEigenvectorToMinor()
	{
		vtkHyperStreamline_SetIntegrationEigenvectorToMinor_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperStreamline_SetIntegrationStepLength_48(HandleRef pThis, double _arg);

	/// <summary>
	/// Set / get a nominal integration step size (expressed as a fraction of
	/// the size of each cell).
	/// </summary>
	public virtual void SetIntegrationStepLength(double _arg)
	{
		vtkHyperStreamline_SetIntegrationStepLength_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperStreamline_SetLogScaling_49(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off logarithmic scaling. If scaling is on, the log base 10
	/// of the computed eigenvalues are used to scale the cross section radii.
	/// </summary>
	public virtual void SetLogScaling(int _arg)
	{
		vtkHyperStreamline_SetLogScaling_49(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperStreamline_SetMaximumPropagationDistance_50(HandleRef pThis, double _arg);

	/// <summary>
	/// Set / get the maximum length of the hyperstreamline expressed as absolute
	/// distance (i.e., arc length) value.
	/// </summary>
	public virtual void SetMaximumPropagationDistance(double _arg)
	{
		vtkHyperStreamline_SetMaximumPropagationDistance_50(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperStreamline_SetNumberOfSides_51(HandleRef pThis, int _arg);

	/// <summary>
	/// Set / get the number of sides for the hyperstreamlines. At a minimum,
	/// number of sides is 3.
	/// </summary>
	public virtual void SetNumberOfSides(int _arg)
	{
		vtkHyperStreamline_SetNumberOfSides_51(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperStreamline_SetRadius_52(HandleRef pThis, double _arg);

	/// <summary>
	/// Set / get the initial tube radius. This is the maximum "elliptical"
	/// radius at the beginning of the tube. Radius varies based on ratio of
	/// eigenvalues.  Note that tube section is actually elliptical and may
	/// become a point or line in cross section in some cases.
	/// </summary>
	public virtual void SetRadius(double _arg)
	{
		vtkHyperStreamline_SetRadius_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperStreamline_SetStartLocation_53(HandleRef pThis, long cellId, int subId, IntPtr pcoords);

	/// <summary>
	/// Specify the start of the hyperstreamline in the cell coordinate system.
	/// That is, cellId and subId (if composite cell), and parametric coordinates.
	/// </summary>
	public void SetStartLocation(long cellId, int subId, IntPtr pcoords)
	{
		vtkHyperStreamline_SetStartLocation_53(GetCppThis(), cellId, subId, pcoords);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperStreamline_SetStartLocation_54(HandleRef pThis, long cellId, int subId, double r, double s, double t);

	/// <summary>
	/// Specify the start of the hyperstreamline in the cell coordinate system.
	/// That is, cellId and subId (if composite cell), and parametric coordinates.
	/// </summary>
	public void SetStartLocation(long cellId, int subId, double r, double s, double t)
	{
		vtkHyperStreamline_SetStartLocation_54(GetCppThis(), cellId, subId, r, s, t);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperStreamline_SetStartPosition_55(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Specify the start of the hyperstreamline in the global coordinate system.
	/// Starting from position implies that a search must be performed to find
	/// initial cell to start integration from.
	/// </summary>
	public void SetStartPosition(IntPtr x)
	{
		vtkHyperStreamline_SetStartPosition_55(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperStreamline_SetStartPosition_56(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Specify the start of the hyperstreamline in the global coordinate system.
	/// Starting from position implies that a search must be performed to find
	/// initial cell to start integration from.
	/// </summary>
	public void SetStartPosition(double x, double y, double z)
	{
		vtkHyperStreamline_SetStartPosition_56(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperStreamline_SetStepLength_57(HandleRef pThis, double _arg);

	/// <summary>
	/// Set / get the length of a tube segment composing the
	/// hyperstreamline. The length is specified as a fraction of the
	/// diagonal length of the input bounding box.
	/// </summary>
	public virtual void SetStepLength(double _arg)
	{
		vtkHyperStreamline_SetStepLength_57(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkHyperStreamline_SetTerminalEigenvalue_58(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/get terminal eigenvalue.  If major eigenvalue falls below this
	/// value, hyperstreamline terminates propagation.
	/// </summary>
	public virtual void SetTerminalEigenvalue(double _arg)
	{
		vtkHyperStreamline_SetTerminalEigenvalue_58(GetCppThis(), _arg);
	}
}
