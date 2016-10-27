﻿namespace Plugin.MediaManager.Abstractions
{
    /// <summary>
    /// Mediafile Metadata. 
    /// </summary>
    public interface IMediaFileMetadata
    {
        /// <summary>
        /// Gets or sets the titel.
        /// </summary>
        /// <value>
        /// The titel.
        /// </value>
        string Titel { get; set; }

        /// <summary>
        /// Gets or sets the artist.
        /// </summary>
        /// <value>
        /// The artist.
        /// </value>
        string Artist { get; set; }

        /// <summary>
        /// Gets or sets the cover.
        /// </summary>
        /// <value>
        /// The cover.
        /// </value>
        object Cover { get; set; }
    }
}
