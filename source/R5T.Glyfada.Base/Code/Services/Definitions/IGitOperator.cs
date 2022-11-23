using System;

using R5T.Glyfada.Base;using R5T.T0064;


namespace R5T.Glyfada
{[ServiceDefinitionMarker]
    public interface IGitOperator:IServiceDefinition
    {
        void Add(string path);
        void Clone(string repositoryURL, string localDirectoryPath);
        void Commit(string path, string message);
        void Fetch(string path);
        string GetRemoteRepositoryUrl(string path, string remoteRepositoryAlias = Constants.OriginDefaultRemoteRepositoryAlias);
        void Init(string directoryPath, bool quiet = false);
        bool IsUnderSourceControl(string path);
        void Pull(string path);
        void Push(string path);
    }
}
