namespace Hotpot.Api
{
    public class Response<T>
    {
        public T Data { get; set; }

        public Response()
        {
        }

        public Response(T data)
        {
            this.Data = data;
        }
    }
}