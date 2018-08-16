namespace ConqSolid.Web.Common
{
    public abstract class CalculatorOperatorBase
    {
        public int LeftVal { get; set; }
        public int RightVal { get; set; }
        public CalculatorOperatorTypeEnum CalculatorOperatorTypeEnum { get; set; }
        public abstract int Calculate();

        public CalculatorOperatorBase(int leftVal, int rightVal)
        {
            this.LeftVal = leftVal;
            this.RightVal = rightVal;
        }
    }
}