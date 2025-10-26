using Microsoft.EntityFrameworkCore;
using OMB.Infra.Database;

namespace OMB.Infra.Repository;

public interface IOMBConfiguration
{
    AppDBContext GetDBContext();
}

public class OMBConfiguration : IOMBConfiguration
{
    private AppDBContext _appDBContext;

    public OMBConfiguration(AppDBContext appDBContext)
    {
        _appDBContext = appDBContext;
    }

    public AppDBContext GetDBContext()
    {
        throw new NotImplementedException();
    }
}
