using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class LoginBUS
    {
        LoginDAO lgDAO = new LoginDAO();

        public IList<LoginDTO> Login(string user, string pass)
        {
            try
            {
                return lgDAO.Login(user, pass);
            }
            catch
            {
                throw new Exception("Error!");
            }
        }

        public IList<LoginDTO> Login(object text, string v)
        {
            throw new NotImplementedException();
        }
    }
}
