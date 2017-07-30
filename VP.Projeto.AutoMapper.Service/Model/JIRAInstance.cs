using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP.Projeto.AutoMapper.Service.Model
{
    public class JIRAInstance
    {
        private static JIRAInstance instance = null;
        public string Host { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        private JIRAInstance(string host, string user, string password)
        {
            this.Host = host;
            this.User = user;
            this.Password = password;
        }

        public static void CreateInstance(string host, string user, string password)
        {
            if (instance == null)
                instance = new JIRAInstance(host, user, password);
        }

        public static JIRAInstance GetInstance()
        {
            return instance;
        }
    }
}
