using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppTest
{
    public class AuthentificationReussiEventArgs: EventArgs
    {
        private string leNom;

        public string LeNom { get => leNom; set => leNom = value; }

        public AuthentificationReussiEventArgs(string _leNom):base()
        {
            leNom = _leNom;
        }
    }
}
