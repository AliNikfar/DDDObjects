using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject.MicroType_TinyType
{
    //Micro types or Tiny Types  only increase the readability of the program
    public class Hour
    {
        private readonly int value;
        public Hour(int value)
        {
            this.value = value;
        }
        public Hour Subtract(Hour input)
        {
            return new Hour(this.value - input.value);
        }
    }

    public class OvetimeCalculator
    {
        public Hour Calculate(Hour workedHours,Hour ContractHours)
        {
            return workedHours.Subtract(ContractHours);
            // Maybee somone make false with this two types and use instead of each other 
            // we using the following classes to fix this
        }

        //the following changes makes change Calculate Method Like This
        public OvertimeHour CalculateByTinyType(WorkedHour workedHours, ContractHour ContractHours)
        {
            return new OvertimeHour( workedHours.Hour.Subtract(ContractHours.Hour));
            
        }

    }
    /// <summary>
    /// this three class is using as MicroType or TinyType
    /// </summary>
    public class WorkedHour
    {
        public WorkedHour(Hour hour)
        {
            Hour = hour;
        }
        public Hour Hour { get; }
    }
    public class ContractHour
    {
        public ContractHour(Hour hour)
        {
            Hour = hour;
        }
        public Hour Hour { get; }
    }
    public class OvertimeHour
    {
        public OvertimeHour(Hour hour)
        {
            Hour = hour;
        }
        public Hour Hour { get; }
    }
}
