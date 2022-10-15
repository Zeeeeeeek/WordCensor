namespace WordCensor.IO;

/**
 * This class will export exportable items in a specific format.
 */
public interface IElementExporter
{
    /**
     * Export the given element
     */
    void Export(IExportableElement element);

    /**
     * Export the given list of elements
     */
    void ExportList<T>(ICollection<T> elements) where T : IExportableElement;
}