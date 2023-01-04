using System;
using System.Threading.Tasks;

namespace itabdemo.Services
{
    public interface IService
    {
        Task<string> notify();
    }
}

