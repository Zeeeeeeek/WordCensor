namespace API.IO;

/**
 * Readers will read elements from a specific source
 */
public interface IElementsReader
{
    /**
     * This method will return a list of elements to be checked
     */
    public List<string> ReadLines();
}