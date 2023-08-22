namespace CQRS_DesignPattern.CQRSPattern.Quaries
{
    public class GetProductUpdateByIDQuery
    {
        public GetProductUpdateByIDQuery(int id)
        {
            ID = id;
        }

        public int ID { get; set; }
    }
}
