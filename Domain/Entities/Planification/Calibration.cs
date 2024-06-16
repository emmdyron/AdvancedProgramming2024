using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedProgramming2024.Domain.Entities.Equipments;

namespace AdvancedProgramming2024.Domain.Entities.Planification
{
    public class Calibration : Planification
    {
        #region Properties


        /// <summary>
        /// Sensor o sensores sometidos a calibracion
        /// </summary>
        public List<Sensor> Sensors { get; set; }


        /// <summary>
        /// Entidad certificadora de la calibracion
        /// </summary>
        public string Certifier { get; }

        #endregion

        public Calibration(string certifier, string operatorName, Guid id) : base(operatorName, id)
        {
            Sensors = new List<Sensor>();
            Certifier = certifier;
        }
    }
}
