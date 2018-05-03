using System.Collections.Generic;
using DataObjects;
using EDCORE.ViewModel;

namespace Abstractions.Stores
{
    public interface IMonitoringStore
    {
        //monitoring

        List<MonitoringEditDto> GetMonitoringEditContainerDto(int managementUnitId);

        List<MonitoringListDTO> GetMonitoringListDtos(List<UserRoleSmallDto> userRole, int userId, int application, int regionId);

        List<ComboBoxValue> GetObservationTypeDtos(int filter);

        void UpdateMonitoring(int managementUnitId, List<MonitoringEditDto> monitoringEditDtos);
    }
}