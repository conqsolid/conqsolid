namespace ConqSolid.Web.Common
{
    public class Adder : CalculatorOperatorBase
    {
        public Adder(int leftVal, int rightVal) : base(leftVal, rightVal)
        {
            this.CalculatorOperatorTypeEnum = CalculatorOperatorTypeEnum.Adder;
        }

        public override void Calculate()
        {
            this.Result = this.LeftVal + this.RightVal;
        }
    }
}