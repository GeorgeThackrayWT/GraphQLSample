namespace Abstractions
{
    public interface ITelerikConvertors
    {
        object GetCellItem(object item);

        string GetCellColumnName(object item);

        string GetControlInfo(object control);
    }
}
