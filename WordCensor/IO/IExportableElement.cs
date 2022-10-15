namespace WordCensor.IO;

/**
 * An exportable object is an element that can be represented as a string.
 */
public interface IExportableElement
{
    /**
    * Returns the string representation of the element.
    */
    string GetStringRepresentation();
}