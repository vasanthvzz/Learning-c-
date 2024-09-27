﻿namespace CommonClassLibrary
{
    public class ZResponse<T>
    {
        public T Data { get; }

        public ZResponse(T data)
        {
            this.Data = data;
        }
    }
}
