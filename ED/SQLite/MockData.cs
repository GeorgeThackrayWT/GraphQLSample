using System;
using System.Linq;
using Abstractions.Stores.Content;
using DataObjects.DTOS;
using MvvmHelpers;
 

namespace SQLite
{

    public class MockData : IMockData
    {      
        public ObservableRangeCollection<ReportDto> Reports
        {
            get
            {
                var result = new ObservableRangeCollection<ReportDto>();

                result.Add(new ReportDto()
                {
                    Name = "Public Site Information",
                    Public = true
                });

                result.Add(new ReportDto()
                {
                    Name = "Public Management Plan",
                    Public = true
                });

                result.Add(new ReportDto()
                {
                    Name = "Public Management Plan - Short Version",
                    Public = true
                });

                result.Add(new ReportDto()
                {
                    Name = "Tasks",
                    Public = false
                });

                result.Add(new ReportDto()
                {
                    Name = "Management Plan",
                    Public = false
                });

                return result;
            }

        }
     
        public ObservableRangeCollection<DocumentDto> Documents
        {
            get
            {
                var result = new ObservableRangeCollection<DocumentDto>();

                result.Add(new DocumentDto()
                {
                    Cabinet = "Estate",
                    ContentType = "application/pdf",
                    Date = "08/03/2017",
                    DocumentName = "Management Plan",
                    FileName = "Public Management Plan (4165)",
                    ErrorMessage = "",
                    Length = "205.6kb",
                    Status = "Pending",
                    UserName = "Malcolm Allen"
                });

                result.Add(new DocumentDto()
                {
                    Cabinet = "Estate",
                    ContentType = "application/pdf",
                    Date = "08/03/2017",
                    DocumentName = "Management Plan",
                    FileName = "Public Management Plan (4165)",
                    ErrorMessage = "",
                    Length = "194.6kb",
                    Status = "Pending",
                    UserName = "Malcolm Allen"
                });


                return result;
            }
        }

    }
}
