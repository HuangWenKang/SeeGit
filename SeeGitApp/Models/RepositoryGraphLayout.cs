﻿namespace SeeGit.Models
{
    using GraphSharp.Controls;
    using Vertices;

	public class RepositoryGraphLayout : GraphLayout<GitVertex, GitEdge, RepositoryGraph>
    {
        public RepositoryGraphLayout()
        {
            HighlightAlgorithmFactory = new ReachableHighlightAlgorithmFactory<GitVertex, GitEdge, RepositoryGraph>();
        }
    }
}