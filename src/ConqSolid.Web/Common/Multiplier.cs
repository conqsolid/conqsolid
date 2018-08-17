namespace ConqSolid.Common
{
    public class Multiplier : CalculatorOperatorBase
    {
        public Multiplier(int leftVal, int rightVal) : base(leftVal, rightVal)
        {
            this.CalculatorOperatorTypeEnum = CalculatorOperatorTypeEnum.Multiplier;
        }

        public override void Calculate()
        {
            this.Result = this.LeftVal * this.RightVal;
        }
    }
}