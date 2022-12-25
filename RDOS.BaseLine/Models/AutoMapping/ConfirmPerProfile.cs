using AutoMapper;
using DocumentFormat.OpenXml.Spreadsheet;
using RDOS.BaseLine.Models.Request;
using RDOS.BaseLine.RDOSInfratructure;

namespace RDOS.BaseLine.Models.AutoMapping
{
    public class ConfirmPerProfile : Profile
    {
        public ConfirmPerProfile()
        {
            CreateMap<BlConfirmPerformance, ConfirmPerformanceModel>().ReverseMap();
            CreateMap<BlConfirmPerformanceDetail, ConfirmPerformanceDetailModel>().ReverseMap();
        }
    }
}
