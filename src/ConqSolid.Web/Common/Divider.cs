namespace ConqSolid.Common
{
    public class Divider : CalculatorOperatorBase
    {
        public Divider(int leftVal, int rightVal) : base(leftVal, rightVal)
        {
            this.CalculatorOperatorTypeEnum = CalculatorOperatorTypeEnum.Divider;
        }

        public override void Calculate()
        {
            this.Result = this.LeftVal / this.RightVal;
        }
    }
}