using System;


namespace R5T.L0035
{
    public class OperatingSystemOperator : IOperatingSystemOperator
    {
        #region Infrastructure

        public static IOperatingSystemOperator Instance { get; } = new OperatingSystemOperator();


        private OperatingSystemOperator()
        {
        }

        #endregion
    }
}
