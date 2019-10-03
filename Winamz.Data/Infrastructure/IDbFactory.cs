using System;

namespace Winamz.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        WinamzDbContext Init();
    }
}