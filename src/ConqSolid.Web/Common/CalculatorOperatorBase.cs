namespace ConqSolid.Web.Common
{
    public abstract class CalculatorOperatorBase
    {
        public int LeftVal { get; set; }
        public int RightVal { get; set; }
        public int Result {get; protected set;}
        public CalculatorOperatorTypeEnum CalculatorOperatorTypeEnum { get; set; }
        public abstract void Calculate();

        public CalculatorOperatorBase(int leftVal, int rightVal)
        {
            this.LeftVal = leftVal;
            this.RightVal = rightVal;
        }
    }
}