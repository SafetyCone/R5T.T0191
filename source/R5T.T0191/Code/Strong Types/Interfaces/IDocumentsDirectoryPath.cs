using System;

using R5T.T0178;
using R5T.T0180;


namespace R5T.T0191
{
    /// <summary>
    /// Strongly-types a string as a documents directory path.
    /// <para>Documents directory paths contain document (human-demographic) files by convention.</para>
    /// </summary>
    [StrongTypeMarker]
    public interface IDocumentsDirectoryPath : IStrongTypeMarker,
        IDirectoryPath
    {
    }
}
