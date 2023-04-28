using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0191
{
    /// <inheritdoc cref="IDocumentsDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class DocumentsDirectoryPath : TypedBase<string>, IStrongTypeMarker,
        IDocumentsDirectoryPath
    {
        public DocumentsDirectoryPath(string value)
            : base(value)
        {
        }
    }
}
