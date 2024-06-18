namespace TaxiBusiness.Services
{
    public interface IService<T>
    {
        public void Upload();
        public T Download();
    }
}
