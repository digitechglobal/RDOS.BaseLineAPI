namespace RDOS.BaseLine.Models.Result
{
    #region ProcessPendingDataTrans
    public class OrderPendingTransModel
    {
        public DateTime BaselineDate { get; set; }
        public List<OrderPendingTransDetailModel> Detail { get; set; }
    }
    public class OrderPendingTransDetailModel
    {
        public string FromStatus { get; set; }
        public string ToStatus { get; set; }
    }
    #endregion
}
