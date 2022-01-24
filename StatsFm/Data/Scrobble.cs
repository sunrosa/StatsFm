namespace StatsFm.Data
{
    public class Scrobble
    {
        /// <summary>
        /// The track that was listened to
        /// </summary>
        /// <value></value>
        public Track Track { get; set; }

        /// <summary>
        /// The scrobbler's username
        /// </summary>
        /// <value></value>
        public string Username { get; set; }

        /// <summary>
        /// When the scrobble occurred
        /// </summary>
        /// <value></value>
        public DateTime ListenedAt { get; set; }

        /// <summary>
        /// When the scrobble was uploaded to the server
        /// </summary>
        /// <value></value>
        public DateTime InsertedAt { get; set; }

        /// <summary>
        /// The player from which the scrobble took place
        /// </summary>
        /// <value></value>
        public string ListenedFrom { get; set; }
    }
}
