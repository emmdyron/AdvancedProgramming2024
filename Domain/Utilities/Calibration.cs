using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedProgramming2024.Domain.Entities.Equipments;

namespace AdvancedProgramming2024.Domain.Utilities
{
    public class Calibration
    {
        #region Properties

        /// <summary>
        /// Fecha de calibraciom
        /// </summary>
        public DateOnly CalibrationDate { get; set; }

        /// <summary>
        /// Sensor o sensores sometidos a calibracion
        /// </summary>
        public Sensor[] Sensors { get; set; }
    
        /// <summary>
        /// Nombre del operador encargado de la calibracion
        /// </summary>
        public string OperatorName { get; }

        /// <summary>
        /// Entidad certificadora de la calibracion
        /// </summary>
        public string Certifier { get; }

        #endregion

        public Calibration(string operatorname, string certifier)
        {
            Sensors = new Sensor[0];
            OperatorName = operatorname;
            Certifier = certifier;
        }
    }
}
