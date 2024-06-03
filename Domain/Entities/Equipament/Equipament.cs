using AdvancedProgramming2024.Domain.Entities.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgramming2024.Domain.Entities.Equipament
{
    public abstract class Equipament
    {
        #region Properties

        /// <summary>
        /// Codigo alfanumerico de la unidad a la que pertenecen
        /// </summary>

        public string Code { get; }

        /// <summary>
        /// Nombre del fabricante
        /// </summary>

        public string ManufacturerName { get; }

        /// <summary>
        /// Magnitud fisica
        /// </summary>
        /// 
        PhysicalMagnitude PhysicalMagnitude { get; }
       
        #endregion

        public Equipament(string code, string manufacturerName, PhysicalMagnitude physicalMagnitude)   
        {
            Code = code;
            ManufacturerName = manufacturerName;
            PhysicalMagnitude = physicalMagnitude;
        }
    }
}