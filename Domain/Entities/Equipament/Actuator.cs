using AdvancedProgramming2024.Domain.Entities.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgramming2024.Domain.Entities.Equipament
{
    public class Actuator : Equipament
    {
        #region Properties
        /// <summary>
        /// Ver si es digital o analogico
        /// </summary>
        public bool IsDigital { get; set; }

        /// <summary>
        /// Codigo del automata que lo controla
        /// </summary>

        public string CodeAuto { get; }


        #endregion

        public Actuator(string code, string manufacturerName, PhysicalMagnitude physicalMagnitude, string codeAuto) : base(code, manufacturerName, physicalMagnitude)
        {
            IsDigital = false;
            CodeAuto = codeAuto;
        }
    }
}
