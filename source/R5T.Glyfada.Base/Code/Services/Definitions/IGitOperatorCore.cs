﻿using System;


namespace R5T.Glyfada
{
    public interface IGitOperatorCore
    {
        void Init(string directoryPath, bool quiet = false);
        void Clone(string repositoryURL, string localDiretoryPath);
    }
}