using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ticari_Otomasyon
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=31.207.87.147;Initial Catalog=QBarSupport;User ID=qbar;Password=1234qbar.");
            baglan.Open();
            return baglan;
        }
    }
}
