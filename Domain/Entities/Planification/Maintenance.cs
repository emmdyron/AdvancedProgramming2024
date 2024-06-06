using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedProgramming2024.Domain.Entities.Types;
using AdvancedProgramming2024.Domain.Entities.Equipments;

namespace AdvancedProgramming2024.Domain.Entities.Planification
{
    public class Maintenance : Planification
    {
        #region Properties

        /// <summary>
        /// Actuador o actuadores sometidos a mantenimiento
        /// </summary>
        public List<Actuator> Actuators { get; set; }

        /// <summary>
        /// Tipo de mantenimiento (Correctivo o Preventivo por ahora)
        /// </summary>
        public MaintenanceTypes MaintenanceType { get; set; }
        #endregion

        public Maintenance(string operatorName) : base(operatorName)
        { 
            Actuators = new List<Actuator>();
        }
    }
}
