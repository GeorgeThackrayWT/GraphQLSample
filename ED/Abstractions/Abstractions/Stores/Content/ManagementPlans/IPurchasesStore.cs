using System.Collections.Generic;
using DataObjects;
using DataObjects.DTOS.ManagementPlans.Editors;
using DataObjects.DTOS.ManagementPlans.PurchaseOrders.Editors;
using EDCORE.ViewModel;

namespace Abstractions.Stores
{
    public interface IPurchasesStore
    {
  

        List<PurchaseOrderListDTO> GetPurchaseOrderListDtos(OrdersSelectionCriterion ordersCriterionarg,List<UserRoleSmallDto> userRole, int userId, int application, int regionId);

        List<ExpenditureDto> GetExpenditures(int managementUnitId);

        List<TenderDto> GetTenders();

        List<SupplierDto> GetSuppliers();


        List<TenderExpenditureDto> GetTenderExpenditures(int tenderId);

        TenderDto GetTender(int tenderId, int userId);

        WPSummaryDTO GetWPExpendituresSummaryThisSite(List<ExpenditureDto> temp);

        WPSummaryDTO GetWPExpendituresSummaryMySites(List<ExpenditureDto> temp);

        void UpdateTender(TenderDto tenderDto, int tenderId, int userId);

        void UpdateTenderExpenditures(int tenderId, List<TenderExpenditureDto> editSet);
        
        void UpdateExpenditures(List<ExpenditureDto> editSet, int managementId);

        void AddToTender(int tenderId, List<int> expenditureIds);

        void RemoveFromTender(int tenderId, List<int> expenditureIds);



    }
}