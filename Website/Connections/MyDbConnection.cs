using System.Data;

namespace Website.Connections
{
    public class MyDbConnection : SqlConnectionBase
    {
        public override IDbConnection Open()
        {
            return OpenDatabase("MyDbConnection");
        }
    }
}