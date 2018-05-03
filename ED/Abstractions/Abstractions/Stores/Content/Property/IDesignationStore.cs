using System.Collections.Generic;
using DataObjects.DTOS;

namespace Abstractions
{
    public interface IDesignationStore : IBaseStore
    {   
        // internal designation model
        List<InternalDesignationDto> GetIntDesignationDtos(int acquistionId);

        void UpdateExternalDesignation(List<ExternalDesignationDto> editSet, int acquisitionId);

        List<ExternalDesignationDto> GetExtDesignationDtos(int acquistionId);

        void UpdateInternalDesignation(List<InternalDesignationDto> editSet, int acquisitionId);
    }
}