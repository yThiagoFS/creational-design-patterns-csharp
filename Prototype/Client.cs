namespace Prototype 
{
    public class Client 
    {
        public void Consume()
        {
            StudioSalesManager manager = new();

            manager["24M"] = new Studio("24M", "Debit", 380000M);

            manager["26M"] = new Studio("26M", "Credit", 480000M);

            manager["28M"] = new Studio("28M", "Credit", 580000M);

            StudioModel firstClone = manager["24M"].Clone();

            StudioModel secondClone = manager["26M"].Clone();

            StudioModel thirdClone = manager["28M"].Clone();
        }
    }
}