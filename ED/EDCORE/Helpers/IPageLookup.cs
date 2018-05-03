namespace EDCORE.Helpers
{
    public interface IPageLookup
    {
        System.Type PageType(string typeName);

        System.Type PageEditorType(string typeName);
    }
}