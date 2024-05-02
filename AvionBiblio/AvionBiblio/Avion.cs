using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvionBiblio
{
    /// <summary>
    /// classe avion
    /// </summary>
    public class Avion
    {
        private string _pilote;
        private string _copilote;
        private string _agentsDeBords1;
        private string _agentsDeBords2;
        private string _agentsDeBords3;

        /// <summary>
        /// constructeur Avion
        /// </summary>
        /// <param name="pilote">attribut pilote</param>
        /// <param name="copilote">attribut copilote</param>
        /// <param name="agentsDeBords1">attribut agents de bord 1</param>
        /// <param name="agentsDeBords2">attribut agents de bord 2</param>
        /// <param name="agentsDeBords3">attribut agents de bord 3</param>
        public Avion(string pilote, string copilote, string agentsDeBords1, string agentsDeBords2, string agentsDeBords3)
        {
            _pilote = pilote;
            _copilote = copilote;
            _agentsDeBords1 = agentsDeBords1;
            _agentsDeBords2 = agentsDeBords2;
            _agentsDeBords3 = agentsDeBords3;
        }
        /// <summary>
        ///  accesseur pilote
        /// </summary>

        public string Pilote 
        { 
            get => _pilote;
            private set
            { 
                _pilote = value;
            }

        }
        /// <summary>
        /// accesseur copilote
        /// </summary>
        public string Copilote
        {
            get => _copilote;
            private set 
            {
                _copilote = value;
            }
        }

        /// <summary>
        ///  accesseur agents de bords 1
        /// </summary>
        public string AgentsDeBords1 
        { 
            get => _agentsDeBords1;
            private set 
            {
                _agentsDeBords1 = value;
            }
        }

        /// <summary>
        /// accesseur agents de bords 2
        /// </summary>
        public string AgentsDeBords2 
        { 
            get => _agentsDeBords2;
            private set
            { 
                _agentsDeBords2 = value;
            }
        }

        /// <summary>
        /// accesseur Agents de bords 3
        /// </summary>
        public string AgentsDeBords3
        { 
            get => _agentsDeBords3;
            private set
            { 
                _agentsDeBords3 = value;
            }
        }
    }
}
