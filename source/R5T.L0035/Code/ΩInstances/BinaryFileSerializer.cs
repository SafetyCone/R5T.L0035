using System;


namespace R5T.L0035
{
    public class BinaryFileSerializer : IBinaryFileSerializer
    {
        #region Infrastructure

        public static IBinaryFileSerializer Instance { get; } = new BinaryFileSerializer();


        private BinaryFileSerializer()
        {
        }

        #endregion
    }
}
