using AutoMapper;
using RDOS.BaseLine.Models.Request;
using RDOS.BaseLine.RDOSInfratructure;

namespace RDOS.BaseLine.Models.AutoMapping
{
    public class BaselineSettingProfile : Profile
    {
        public BaselineSettingProfile()
        {
            CreateMap<BlBlsettingInformation, BaselineSettingModel>().ReverseMap();
            CreateMap<BlBlsettingProcessPending, ProcessPendingModel>().ReverseMap();
            CreateMap<BlBlsettingProcess, BaseLineProcessModel>().ReverseMap();
            CreateMap<BlFreeProcess, BlFreeProcessModel>().ReverseMap();
            CreateMap<BlBlsettingEmail, BaselineSettingEmailModel>().ReverseMap();
            CreateMap<BlBlsettingProcessDetail, BlBlsettingProcess>().ReverseMap();
            CreateMap<BlCurrentCustomerPerformanceDaily, BlCustomerPerformanceDaily>().ReverseMap()
                .ForMember(d => d.Id, o => o.MapFrom(x => Guid.NewGuid()));
            CreateMap<BlCusPerDailySkubuyedDetail, BlCustomerPerformanceDaily>().ReverseMap()
                .ForMember(d => d.Id, o => o.MapFrom(x => Guid.NewGuid()));
            CreateMap<BlCloseStock, BlCloseStock>().ReverseMap()
                .ForMember(d => d.Id, o => o.MapFrom(x => Guid.NewGuid()))
                .ForMember(d => d.IsPrevious, o => o.MapFrom(x => true));
            CreateMap<BlCurrentCusPerDailySkubuyedDetail, BlCusPerDailySkubuyedDetail>().ReverseMap()
                .ForMember(d => d.Id, o => o.MapFrom(x => Guid.NewGuid()));
        }
    }
}
