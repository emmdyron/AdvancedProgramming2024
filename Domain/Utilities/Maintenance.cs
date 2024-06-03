using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedProgramming2024.Domain.Entities.Equipments;

namespace AdvancedProgramming2024.Domain.Utilities
{
    public class Maintenance
    {
        #region Properties

        /// <summary>
        /// Actuador o actuadores sometidos a mantenimiento
        /// </summary>
        public Actuator[] Actuators { get; set; }

        /// <summary>
        /// Tipo de mantenimiento (Correctivo o Preventivo)
        /// </summary>
        public bool IsCorrective { get; set; }

        /// <summary>
        /// Fecha de mantenimiento
        /// </summary>
        public DateOnly MaintenanceDate { get; set; }

        /// <summary>
        /// Nombre del operador encargado del mantenimiento
        /// </summary>
        public string OperatorName { get; }

        #endregion

        public Maintenance(string operatorname)
        {
            IsCorrective = false;
            Actuators = new Actuator[0];
            OperatorName = operatorname;
        }
    }
}
