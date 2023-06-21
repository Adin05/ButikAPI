namespace ButikAPI.ViewModels
{
    public class BaseViewModel<T>
    {
        public BaseViewModel()
        {
        }

        public bool IsSuccess{ get; set; } = true;
        public string ErrorMessage { get; set; }
        public T Data { get; set; }
        public List<T> Datas { get; set; }
    }
}
