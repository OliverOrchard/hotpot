namespace Hotpot.Data
{
    public interface IConnectionStringProvider
    {
        string GetConnection();
        string GetMasterConnection();
    }
}