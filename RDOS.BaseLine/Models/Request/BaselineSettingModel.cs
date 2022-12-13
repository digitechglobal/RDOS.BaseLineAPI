using RDOS.BaseLine.RDOSInfratructure;
using static RDOS.BaseLine.Models.Results;

namespace RDOS.BaseLine.Models.Request
{
    public class BaselineSettingModel
    {
        public string Description { get; set; }
        public int LeadDate { get; set; } = 0;
        public int MonthlyBaselineDate { get; set; } = 0;
        public bool IsProcessPendingData { get; set; } = false;
        public string ProcessPendingTime { get; set; }
        public string ProcessTime { get; set; }
        public virtual List<ProcessPendingModel> ProcessPendings { get; set; }
        public virtual List<BaseLineProcessModel> BaseLineProcesses { get; set; }
        public BaselineSettingEmailModel? BaselineSettingEmail { get; set; }
    }

    public class ProcessPendingModel
    {
        public string Description { get; set; }
        public string FromStatus { get; set; }
        public string ToStatus { get; set; }
    }

    public class BaseLineProcessModel
    {
        public string ProcessCode { get; set; }
        public int? Priority { get; set; } = 0;
        public bool? IsSequentialProcessing { get; set; } = false;
    }

    public class BaselineSettingEmailModel
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Cc { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
    }

    // Model detail
    public class BlBlsettingProcessDetail : BlBlsettingProcess
    {
        public BlBlprocess Process { get; set; }
    }
    public class BaselineSettingDetailModel
    {
        public BlBlsettingInformation BlBlsettingInformation { get; set; }
        public virtual List<BlBlsettingProcessPending> ProcessPendings { get; set; }
        public virtual List<BlBlsettingProcessDetail> BaseLineProcesses { get; set; }
        public BlBlsettingEmail? BaselineSettingEmail { get; set; }
    }

    public class ListBaselineSetting
    {
        public List<BlBlsettingInformation> Items { get; set; }
        public MetaData MetaData { get; set; }
    }

    public class BaselineSearch : EcoParameters
    {

    }
}
