using AdvancedProgramming2024.Domain.Entities.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgramming2024.Domain.Entities.Equipament
{
    public class Sensor : Equipament
    {
        #region Properties

        /// <summary>
        /// Principio de funcionamieto
        /// </summary>

        public string Function { get; }

        /// <summary>
        /// Protocolo de comunicacion
        /// </summary>
        Protocol Protocol { get; }

        #endregion

        public Sensor(string code, string manufacturerName, PhysicalMagnitude physicalMagnitude, string function, Protocol protocol) : base(code, manufacturerName,physicalMagnitude) 
        {
            Function = function;
            Protocol = protocol;
        }
    }
}
