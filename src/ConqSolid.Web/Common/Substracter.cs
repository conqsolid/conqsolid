namespace ConqSolid.Web.Common
{
    public class Substracter : CalculatorOperatorBase
    {
        public Substracter(int leftVal, int rightVal) : base(leftVal, rightVal)
        {
            this.CalculatorOperatorTypeEnum = CalculatorOperatorTypeEnum.Substracter;
        }

        public override void Calculate()
        {
            this.Result = this.LeftVal - this.RightVal;
        }
    }
}