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
            CreateMap<BlBlsettingEmail, BaselineSettingEmailModel>().ReverseMap();
            CreateMap<BlBlsettingProcessDetail, BlBlsettingProcess>().ReverseMap();
        }
    }
}
