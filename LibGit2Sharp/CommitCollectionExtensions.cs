﻿using LibGit2Sharp.Core;

namespace LibGit2Sharp
{
    public static class CommitCollectionExtensions
    {
        /// <summary>
        ///   Starts enumerating the <paramref name="commitCollection"/> at the specified branch.
        /// </summary>
        /// <param name="commitCollection">The commit collection to enumerate.</param>
        /// <param name = "branch">The branch.</param>
        /// <returns></returns>
        public static CommitCollection StartingAt(this CommitCollection commitCollection, Branch branch)
        {
            Ensure.ArgumentNotNull(branch, "branch");

            return commitCollection.StartingAt(branch.Tip.Sha);
        }

        /// <summary>
        ///   Starts enumerating the <paramref name="commitCollection"/> at the specified reference.
        /// </summary>
        /// <param name="commitCollection">The commit collection to enumerate.</param>
        /// <param name = "reference">The reference.</param>
        /// <returns></returns>
        public static CommitCollection StartingAt(this CommitCollection commitCollection, Reference reference)
        {
            Ensure.ArgumentNotNull(reference, "reference");

            return commitCollection.StartingAt(reference.ResolveToDirectReference().Target.Sha);
        }
    }
}
