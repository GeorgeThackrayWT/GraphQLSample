namespace DataObjects.DTOS.lookups
{
    public class PurchaseOrderDateOptionsDTO : ComboBoxValue
    {
     

        public OrdersSelectionCriterion OrdersSelectionCriterion { get; set; }
    }

    public class HarvestingDateOptionsDTO : ComboBoxValue
    {


        public OrdersSelectionCriterion OrdersSelectionCriterion { get; set; }
    }
}
