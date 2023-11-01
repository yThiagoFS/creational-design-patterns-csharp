namespace Prototype 
{
    public class StudioSalesManager 
    {
        private Dictionary<string, StudioModel> _studioModel = new();

        public StudioModel this[string index] 
        {
            get { return _studioModel[index]; }
            set { _studioModel[index] = value; }
        }
    }
}