using static RDOS.BaseLine.Models.Results;

namespace RDOS.BaseLine.Service.Interface
{
    public interface IMySchedular
    {
        Task StartAsync(CancellationToken cancellationToken);
    }
}
