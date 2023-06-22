using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4projekt3.Model
{
    public static class Configuration
    {
        public static string ConnectionString { get; } =
            "Data Source=MAINPC\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30" +
            ";Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;" +
            "Multi Subnet Failover=False";
    }
}
