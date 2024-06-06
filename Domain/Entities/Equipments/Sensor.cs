using AdvancedProgramming2024.Domain.Entities.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgramming2024.Domain.Entities.Equipments
{
    public class Sensor : Equipment
    {
        #region Properties

        /// <summary>
        /// Principio de funcionamieto
        /// </summary>

        public string Function { get; set; }

        /// <summary>
        /// Protocolo de comunicacion
        /// </summary>
        public Protocol Protocol { get; set; }

        #endregion

        public Sensor(string code, string manufacturerName, PhysicalMagnitude physicalMagnitude, string function, Protocol protocol) : base(code, manufacturerName,physicalMagnitude) 
        {
            Function = function;
            Protocol = protocol;
        }
    }
}
