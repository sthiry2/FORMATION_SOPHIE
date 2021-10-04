using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UtilisationPartageeDesRessources
{
    class MaRessource
    {
        int m_mavariable;

        public MaRessource()
        {
            m_mavariable = 0;
        }

        public int MaVar
        {
            get { return m_mavariable; }
            set { m_mavariable = value; }
        }
    }
}
