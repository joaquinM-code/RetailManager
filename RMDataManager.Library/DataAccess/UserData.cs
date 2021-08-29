using RMDataManager.Library.Internal.DataAccess;
using RMDataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMDataManager.Library.DataAccess
{
    public class UserData
    {
        public List<UserModel> GetUserById(string Id)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var parameters = new { Id };

            var output = sql.LoadData<UserModel, dynamic>("dbo.SP_UserLookup", parameters, "RMData");

            return output;
        }
    }
}
