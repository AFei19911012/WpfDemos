using System;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
/// Base class for all the mummy wrapped classes in Kitware.VTK.
/// </summary>
public class WrappedObject : Kitware.mummy.Runtime.WrappedObject
{
	/// <summary>
	/// Export layer functions for 'DICOM' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string DICOMEL_dll = "Kitware.VTK.DICOM.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'ViewsInfovis' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string ViewsInfovisEL_dll = "Kitware.VTK.ViewsInfovis.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'CommonColor' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string CommonColorEL_dll = "Kitware.VTK.CommonColor.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'ViewsContext2D' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string ViewsContext2DEL_dll = "Kitware.VTK.ViewsContext2D.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'TestingRendering' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string TestingRenderingEL_dll = "Kitware.VTK.TestingRendering.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'RenderingOpenXRRemoting' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string RenderingOpenXRRemotingEL_dll = "Kitware.VTK.RenderingOpenXRRemoting.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'RenderingOpenXR' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string RenderingOpenXREL_dll = "Kitware.VTK.RenderingOpenXR.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'RenderingVR' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string RenderingVREL_dll = "Kitware.VTK.RenderingVR.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'RenderingVolumeOpenGL2' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string RenderingVolumeOpenGL2EL_dll = "Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'RenderingLabel' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string RenderingLabelEL_dll = "Kitware.VTK.RenderingLabel.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'RenderingLOD' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string RenderingLODEL_dll = "Kitware.VTK.RenderingLOD.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'RenderingLICOpenGL2' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string RenderingLICOpenGL2EL_dll = "Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'RenderingImage' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string RenderingImageEL_dll = "Kitware.VTK.RenderingImage.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'RenderingExternal' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string RenderingExternalEL_dll = "Kitware.VTK.RenderingExternal.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'RenderingContextOpenGL2' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string RenderingContextOpenGL2EL_dll = "Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'IOVeraOut' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string IOVeraOutEL_dll = "Kitware.VTK.IOVeraOut.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'IOTecplotTable' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string IOTecplotTableEL_dll = "Kitware.VTK.IOTecplotTable.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'IOSegY' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string IOSegYEL_dll = "Kitware.VTK.IOSegY.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'IOParallelXML' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string IOParallelXMLEL_dll = "Kitware.VTK.IOParallelXML.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'IOParallel' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string IOParallelEL_dll = "Kitware.VTK.IOParallel.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'IOPLY' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string IOPLYEL_dll = "Kitware.VTK.IOPLY.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'IOOggTheora' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string IOOggTheoraEL_dll = "Kitware.VTK.IOOggTheora.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'IONetCDF' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string IONetCDFEL_dll = "Kitware.VTK.IONetCDF.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'IOMotionFX' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string IOMotionFXEL_dll = "Kitware.VTK.IOMotionFX.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'IOMINC' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string IOMINCEL_dll = "Kitware.VTK.IOMINC.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'IOLSDyna' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string IOLSDynaEL_dll = "Kitware.VTK.IOLSDyna.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'IOInfovis' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string IOInfovisEL_dll = "Kitware.VTK.IOInfovis.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'IOImport' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string IOImportEL_dll = "Kitware.VTK.IOImport.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'IOIOSS' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string IOIOSSEL_dll = "Kitware.VTK.IOIOSS.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'IOVideo' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string IOVideoEL_dll = "Kitware.VTK.IOVideo.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'IOMovie' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string IOMovieEL_dll = "Kitware.VTK.IOMovie.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'IOExportPDF' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string IOExportPDFEL_dll = "Kitware.VTK.IOExportPDF.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'IOExportGL2PS' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string IOExportGL2PSEL_dll = "Kitware.VTK.IOExportGL2PS.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'RenderingGL2PSOpenGL2' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string RenderingGL2PSOpenGL2EL_dll = "Kitware.VTK.RenderingGL2PSOpenGL2.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'IOExport' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string IOExportEL_dll = "Kitware.VTK.IOExport.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'RenderingVtkJS' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string RenderingVtkJSEL_dll = "Kitware.VTK.RenderingVtkJS.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'RenderingSceneGraph' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string RenderingSceneGraphEL_dll = "Kitware.VTK.RenderingSceneGraph.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'IOExodus' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string IOExodusEL_dll = "Kitware.VTK.IOExodus.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'IOEnSight' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string IOEnSightEL_dll = "Kitware.VTK.IOEnSight.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'IOCityGML' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string IOCityGMLEL_dll = "Kitware.VTK.IOCityGML.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'IOChemistry' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string IOChemistryEL_dll = "Kitware.VTK.IOChemistry.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'IOCesium3DTiles' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string IOCesium3DTilesEL_dll = "Kitware.VTK.IOCesium3DTiles.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'IOGeometry' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string IOGeometryEL_dll = "Kitware.VTK.IOGeometry.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'IOCONVERGECFD' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string IOCONVERGECFDEL_dll = "Kitware.VTK.IOCONVERGECFD.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'IOHDF' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string IOHDFEL_dll = "Kitware.VTK.IOHDF.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'IOCGNSReader' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string IOCGNSReaderEL_dll = "Kitware.VTK.IOCGNSReader.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'IOAsynchronous' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string IOAsynchronousEL_dll = "Kitware.VTK.IOAsynchronous.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'IOAMR' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string IOAMREL_dll = "Kitware.VTK.IOAMR.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'InteractionImage' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string InteractionImageEL_dll = "Kitware.VTK.InteractionImage.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'ImagingStencil' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string ImagingStencilEL_dll = "Kitware.VTK.ImagingStencil.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'ImagingStatistics' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string ImagingStatisticsEL_dll = "Kitware.VTK.ImagingStatistics.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'ImagingMorphological' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string ImagingMorphologicalEL_dll = "Kitware.VTK.ImagingMorphological.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'ImagingMath' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string ImagingMathEL_dll = "Kitware.VTK.ImagingMath.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'ImagingFourier' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string ImagingFourierEL_dll = "Kitware.VTK.ImagingFourier.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'IOSQL' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string IOSQLEL_dll = "Kitware.VTK.IOSQL.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'GeovisCore' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string GeovisCoreEL_dll = "Kitware.VTK.GeovisCore.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'InfovisLayout' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string InfovisLayoutEL_dll = "Kitware.VTK.InfovisLayout.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'ViewsCore' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string ViewsCoreEL_dll = "Kitware.VTK.ViewsCore.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'InteractionWidgets' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string InteractionWidgetsEL_dll = "Kitware.VTK.InteractionWidgets.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'RenderingVolume' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string RenderingVolumeEL_dll = "Kitware.VTK.RenderingVolume.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'RenderingAnnotation' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string RenderingAnnotationEL_dll = "Kitware.VTK.RenderingAnnotation.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'ImagingHybrid' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string ImagingHybridEL_dll = "Kitware.VTK.ImagingHybrid.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'ImagingColor' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string ImagingColorEL_dll = "Kitware.VTK.ImagingColor.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'InteractionStyle' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string InteractionStyleEL_dll = "Kitware.VTK.InteractionStyle.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'FiltersTopology' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string FiltersTopologyEL_dll = "Kitware.VTK.FiltersTopology.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'FiltersSelection' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string FiltersSelectionEL_dll = "Kitware.VTK.FiltersSelection.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'FiltersSMP' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string FiltersSMPEL_dll = "Kitware.VTK.FiltersSMP.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'FiltersProgrammable' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string FiltersProgrammableEL_dll = "Kitware.VTK.FiltersProgrammable.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'FiltersPoints' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string FiltersPointsEL_dll = "Kitware.VTK.FiltersPoints.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'FiltersVerdict' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string FiltersVerdictEL_dll = "Kitware.VTK.FiltersVerdict.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'FiltersParallelImaging' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string FiltersParallelImagingEL_dll = "Kitware.VTK.FiltersParallelImaging.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'FiltersImaging' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string FiltersImagingEL_dll = "Kitware.VTK.FiltersImaging.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'ImagingGeneral' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string ImagingGeneralEL_dll = "Kitware.VTK.ImagingGeneral.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'FiltersGeometryPreview' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string FiltersGeometryPreviewEL_dll = "Kitware.VTK.FiltersGeometryPreview.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'FiltersGeneric' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string FiltersGenericEL_dll = "Kitware.VTK.FiltersGeneric.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'FiltersFlowPaths' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string FiltersFlowPathsEL_dll = "Kitware.VTK.FiltersFlowPaths.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'FiltersDSP' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string FiltersDSPEL_dll = "Kitware.VTK.FiltersDSP.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'FiltersAMR' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string FiltersAMREL_dll = "Kitware.VTK.FiltersAMR.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'FiltersParallel' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string FiltersParallelEL_dll = "Kitware.VTK.FiltersParallel.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'FiltersTexture' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string FiltersTextureEL_dll = "Kitware.VTK.FiltersTexture.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'FiltersModeling' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string FiltersModelingEL_dll = "Kitware.VTK.FiltersModeling.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'DomainsChemistryOpenGL2' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string DomainsChemistryOpenGL2EL_dll = "Kitware.VTK.DomainsChemistryOpenGL2.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'RenderingOpenGL2' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string RenderingOpenGL2EL_dll = "Kitware.VTK.RenderingOpenGL2.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'RenderingHyperTreeGrid' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string RenderingHyperTreeGridEL_dll = "Kitware.VTK.RenderingHyperTreeGrid.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'RenderingUI' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string RenderingUIEL_dll = "Kitware.VTK.RenderingUI.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'FiltersHybrid' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string FiltersHybridEL_dll = "Kitware.VTK.FiltersHybrid.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'DomainsChemistry' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string DomainsChemistryEL_dll = "Kitware.VTK.DomainsChemistry.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'ChartsCore' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string ChartsCoreEL_dll = "Kitware.VTK.ChartsCore.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'InfovisCore' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string InfovisCoreEL_dll = "Kitware.VTK.InfovisCore.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'FiltersExtraction' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string FiltersExtractionEL_dll = "Kitware.VTK.FiltersExtraction.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'IOXML' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string IOXMLEL_dll = "Kitware.VTK.IOXML.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'IOXMLParser' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string IOXMLParserEL_dll = "Kitware.VTK.IOXMLParser.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'ParallelCore' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string ParallelCoreEL_dll = "Kitware.VTK.ParallelCore.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'IOLegacy' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string IOLegacyEL_dll = "Kitware.VTK.IOLegacy.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'IOCore' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string IOCoreEL_dll = "Kitware.VTK.IOCore.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'FiltersStatistics' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string FiltersStatisticsEL_dll = "Kitware.VTK.FiltersStatistics.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'ImagingSources' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string ImagingSourcesEL_dll = "Kitware.VTK.ImagingSources.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'IOImage' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string IOImageEL_dll = "Kitware.VTK.IOImage.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'RenderingContext2D' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string RenderingContext2DEL_dll = "Kitware.VTK.RenderingContext2D.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'RenderingFreeType' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string RenderingFreeTypeEL_dll = "Kitware.VTK.RenderingFreeType.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'RenderingCore' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string RenderingCoreEL_dll = "Kitware.VTK.RenderingCore.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'FiltersSources' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string FiltersSourcesEL_dll = "Kitware.VTK.FiltersSources.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'ImagingCore' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string ImagingCoreEL_dll = "Kitware.VTK.ImagingCore.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'FiltersGeneral' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string FiltersGeneralEL_dll = "Kitware.VTK.FiltersGeneral.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'FiltersGeometry' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string FiltersGeometryEL_dll = "Kitware.VTK.FiltersGeometry.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'CommonComputationalGeometry' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string CommonComputationalGeometryEL_dll = "Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'FiltersCore' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string FiltersCoreEL_dll = "Kitware.VTK.FiltersCore.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'CommonExecutionModel' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string CommonExecutionModelEL_dll = "Kitware.VTK.CommonExecutionModel.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'CommonDataModel' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string CommonDataModelEL_dll = "Kitware.VTK.CommonDataModel.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'CommonSystem' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string CommonSystemEL_dll = "Kitware.VTK.CommonSystem.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'CommonMisc' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string CommonMiscEL_dll = "Kitware.VTK.CommonMisc.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'CommonTransforms' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string CommonTransformsEL_dll = "Kitware.VTK.CommonTransforms.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'CommonMath' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string CommonMathEL_dll = "Kitware.VTK.CommonMath.Unmanaged.dll";

	/// <summary>
	/// Export layer functions for 'CommonCore' are exported from
	/// the DLL named by the value of this variable.
	/// </summary>
	public const string CommonCoreEL_dll = "Kitware.VTK.CommonCore.Unmanaged.dll";

	/// <summary>
	/// Constructor expected by the mummy Runtime.
	/// </summary>
	protected WrappedObject(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
		 
	}
}
