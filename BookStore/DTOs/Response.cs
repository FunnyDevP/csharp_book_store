namespace BookStore.DTOs
{
    public class ResponseSuccess<T>
    {
        public ResponseSuccess(T data)
        {
            Data = data;
        }

        public T Data { get; set; }
    }
}