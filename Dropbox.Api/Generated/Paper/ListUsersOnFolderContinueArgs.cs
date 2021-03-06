// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Paper
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The list users on folder continue args object</para>
    /// </summary>
    /// <seealso cref="Dropbox.Api.Paper.RefPaperDoc" />
    public class ListUsersOnFolderContinueArgs : RefPaperDoc
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ListUsersOnFolderContinueArgs> Encoder = new ListUsersOnFolderContinueArgsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ListUsersOnFolderContinueArgs> Decoder = new ListUsersOnFolderContinueArgsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListUsersOnFolderContinueArgs"
        /// /> class.</para>
        /// </summary>
        /// <param name="docId">The doc id</param>
        /// <param name="cursor">The cursor obtained from <see
        /// cref="Dropbox.Api.Paper.Routes.PaperUserRoutes.DocsFolderUsersListAsync" /> or <see
        /// cref="Dropbox.Api.Paper.Routes.PaperUserRoutes.DocsFolderUsersListContinueAsync"
        /// />. Allows for pagination.</param>
        public ListUsersOnFolderContinueArgs(string docId,
                                             string cursor)
            : base(docId)
        {
            if (cursor == null)
            {
                throw new sys.ArgumentNullException("cursor");
            }

            this.Cursor = cursor;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListUsersOnFolderContinueArgs"
        /// /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public ListUsersOnFolderContinueArgs()
        {
        }

        /// <summary>
        /// <para>The cursor obtained from <see
        /// cref="Dropbox.Api.Paper.Routes.PaperUserRoutes.DocsFolderUsersListAsync" /> or <see
        /// cref="Dropbox.Api.Paper.Routes.PaperUserRoutes.DocsFolderUsersListContinueAsync"
        /// />. Allows for pagination.</para>
        /// </summary>
        public string Cursor { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ListUsersOnFolderContinueArgs" />.</para>
        /// </summary>
        private class ListUsersOnFolderContinueArgsEncoder : enc.StructEncoder<ListUsersOnFolderContinueArgs>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ListUsersOnFolderContinueArgs value, enc.IJsonWriter writer)
            {
                WriteProperty("doc_id", value.DocId, writer, enc.StringEncoder.Instance);
                WriteProperty("cursor", value.Cursor, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ListUsersOnFolderContinueArgs" />.</para>
        /// </summary>
        private class ListUsersOnFolderContinueArgsDecoder : enc.StructDecoder<ListUsersOnFolderContinueArgs>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ListUsersOnFolderContinueArgs"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ListUsersOnFolderContinueArgs Create()
            {
                return new ListUsersOnFolderContinueArgs();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(ListUsersOnFolderContinueArgs value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "doc_id":
                        value.DocId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "cursor":
                        value.Cursor = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
