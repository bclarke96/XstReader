﻿// Project site: https://github.com/iluvadev/XstReader
//
// Based on the great work of Dijji. 
// Original project: https://github.com/dijji/XstReader
//
// Issues: https://github.com/iluvadev/XstReader/issues
// License (Ms-PL): https://github.com/iluvadev/XstReader/blob/master/license.md
//
// Copyright (c) 2021, iluvadev, and released under Ms-PL License.

using System.ComponentModel;

namespace XstReader.Exporter
{
    public class XstExportOptions
    {

        [Category("Message Header")]
        [DisplayName("Show Headers")]
        [Description("Show message headers in exported messages as HTML: Subject, To, From...")]
        public bool ShowHeadersInMessages { get; set; } = true;

        [Category("Message Header")]
        [DisplayName("Hidden Attachments")]
        [Description("Show hidden attachments in the list of Attachments in the message header")]
        public bool ShowHiddenAttachmentsInList { get; set; } = false;

        [Category("Attachments")]
        [DisplayName("Embed Attachments")]
        [Description("Embed all attachments of messages in exported file")]
        public bool EmbedAttachmentsInFile { get; set; } = true;


        [Category("Messages")]
        [DisplayName("Show Details")]
        [Description("Show section Details in exported file")]
        public bool ShowDetails { get; set; } = true;

        [Category("Properties")]
        [DisplayName("Show Properties description")]
        [Description("Show section with all description of used known properties")]
        public bool ShowPropertiesDescriptions { get; set; } = true;


        public XstExportOptions Clone()
            => new XstExportOptions
            {
                ShowHeadersInMessages = ShowHeadersInMessages,
                ShowHiddenAttachmentsInList = ShowHiddenAttachmentsInList,
                EmbedAttachmentsInFile = EmbedAttachmentsInFile,
                ShowPropertiesDescriptions = ShowPropertiesDescriptions,
            };
    }
}
