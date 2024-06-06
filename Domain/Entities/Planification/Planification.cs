using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgramming2024.Domain.Entities.Planification
{
    public class Planification
    {

        #region Properties

        /// <summary>
        /// Fecha de mantenimiento
        /// </summary>
        public DateTime MaintenanceDate { get; set; }

        /// <summary>
        /// Nombre del operador encargado del mantenimiento
        /// </summary>
        public string OperatorName { get; set; }

        #endregion

        public Planification(string operatorName)
        {
            OperatorName = operatorName;
        }

    }
}
