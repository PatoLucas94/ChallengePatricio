using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengePatricio.Abstracciones
{
    public abstract class FormaGeometrica
    {
        public abstract decimal _lado { get; set; }

        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();
    }
}
