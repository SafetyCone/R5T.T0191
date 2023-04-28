using System;

using R5T.T0132;


namespace R5T.T0191.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        public IDataDirectoryPath ToDataDirectoryPath(string value)
        {
            var output = new DataDirectoryPath(value);
            return output;
        }

        public IDocumentsDirectoryPath ToDocumentsDirectoryPath(string value)
        {
            var output = new DocumentsDirectoryPath(value);
            return output;
        }
    }
}
