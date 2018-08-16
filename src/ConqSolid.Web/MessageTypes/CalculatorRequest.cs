using ConqSolid.Common;

namespace ConqSolid.MessageTypes
{
    public class CalculatorRequest
    {
        public int LeftVal { get; set; }
        public int RightVal { get; set; }
        public CalculatorOperatorTypeEnum CalculatorOperatorType;  
    }
}