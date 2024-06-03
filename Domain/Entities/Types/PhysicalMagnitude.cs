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

        public string Name { get; }

        /// <summary>
        /// Unidad de medida
        /// </summary>

        public string UnitMeasurement { get; }

        #endregion

        /// <summary>
        /// Inicializando
        /// </summary>

        public PhysicalMagnitude(string name, string unitMeasurement)
        {
            Name = name;
            UnitMeasurement = unitMeasurement;
        }


    }

}
