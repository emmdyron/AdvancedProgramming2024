using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgramming2024.Domain.Entities.Types
{
    public class PhysicalMagnitude
    {

        #region Properties

        /// <summary>
        /// Nombre de la magnitud fisica
        /// </summary>

        public string Name { get; set; }

        /// <summary>
        /// Unidad de medida
        /// </summary>

        public string MeasurementUnit { get; set; }

        #endregion

        /// <summary>
        /// Inicializando
        /// </summary>

        public PhysicalMagnitude(string name, string measurementunit)
        {
            Name = name;
            MeasurementUnit = measurementunit;
        }


    }

}
