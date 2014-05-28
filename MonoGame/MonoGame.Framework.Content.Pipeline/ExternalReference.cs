﻿// MonoGame - Copyright (C) The MonoGame Team
// This file is subject to the terms and conditions defined in
// file 'LICENSE.txt', which is part of this source code package.

using System;
using System.IO;

namespace Microsoft.Xna.Framework.Content.Pipeline
{
    /// <summary>
    /// Specifies external references to a data file for the content item.
    /// 
    /// While the object model is instantiated, reference file names are absolute. When the file containing the external reference is serialized to disk, file names are relative to the file. This allows movement of the content tree to a different location without breaking internal links.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ExternalReference<T> : ContentItem
    {
        /// <summary>
        /// Gets and sets the file name of an ExternalReference.
        /// </summary>
        public string Filename { get; set; }

        /// <summary>
        /// Initializes a new instance of ExternalReference.
        /// </summary>
        public ExternalReference()
        {
            Filename = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of ExternalReference.
        /// </summary>
        /// <param name="filename">The name of the referenced file.</param>
        public ExternalReference(string filename)
        {
            if (string.IsNullOrEmpty(filename))
                throw new ArgumentNullException("filename");
            Filename = filename;
        }

        /// <summary>
        /// Initializes a new instance of ExternalReference, specifying the file path relative to another content item.
        /// </summary>
        /// <param name="filename">The name of the referenced file.</param>
        /// <param name="relativeToContent">The content that the path specified in filename is relative to.</param>
        public ExternalReference(string filename, ContentIdentity relativeToContent)
        {
            if (string.IsNullOrEmpty(filename))
                throw new ArgumentNullException("filename");
            if (relativeToContent == null)
                throw new ArgumentNullException("relativeToContent");
            if (string.IsNullOrEmpty(relativeToContent.SourceFilename))
                throw new ArgumentNullException("relativeToContent.SourceFilename");

#if WINRT
            const char notSeparator = '/';
            const char separator = '\\';
#else
            const char notSeparator = '\\';
            var separator = Path.DirectorySeparatorChar;
#endif
            // Get a uri for the asset path using the file:// schema and no host
            var src = new Uri("file:///" + relativeToContent.SourceFilename.Replace(notSeparator, separator));

            // Add the relative path to the external reference
            var dst = new Uri(src, filename.Replace(notSeparator, separator));

            // The uri now contains the path to the external reference
            // Get the local path and skip the first character (the path separator)
            Filename = dst.LocalPath.Substring(1);
        }
    }
}
