namespace inclass_Interfaces
{
    public interface IRepositoy
    {
         void Add();

         void GetById();
    }

    public class FileRepository : IRepositoy
    {
        public void Add()
        {
            throw new System.NotImplementedException();
        }

        public void Get()
        {
            throw new System.NotImplementedException();
        }

        public void GetById()
        {
            throw new System.NotImplementedException();
        }
    }
}